using System.ComponentModel;
using FullscreenBrowserOverlay.Entities;
using FullscreenBrowserOverlay.Extensions;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Diagnostics;
using System.Reflection;
using System.Web;

namespace FullscreenBrowserOverlay
{
    public partial class MainForm : Form
    {
        private readonly WebView2 _engine;
        private readonly Store _store;
        private StoreItem? _selectedItem;

        #region Abstracts

        private void ClickItem(MouseButtons button, StoreItem item, ToolStripDropDown menu)
        {
            if (button == MouseButtons.Left)
            {
                SelectItem(item.Id);
            }
            else if (button == MouseButtons.Middle)
            {
                if (_selectedItem == item) _engine.CoreWebView2.Navigate("about:blank");
                _store.Items.Remove(item);
                _store.Save();
                menu.Close();
            }
            else if (button == MouseButtons.Right)
            {
                using var editForm = new EditForm(item);
                if (editForm.ShowDialog() != DialogResult.OK) return;
                _store.Save();
                SelectItem(item.Id);
            }
        }

        private void SelectItem(Guid? id)
        {
            var item = _store.Items.FirstOrDefault(x => x.Id == id);
            if (item == null) return;
            _engine.CoreWebView2.Navigate(item.Url);
            _selectedItem = item;
            _store.SelectedItemId = id;
            _store.Save();
        }

        #endregion

        #region Constructor

        public MainForm(Store store)
        {
            InitializeComponent();
            _engine = new WebView2();
            _engine.CoreWebView2InitializationCompleted += OnWebViewInitialized;
            _engine.DefaultBackgroundColor = Color.Transparent;
            _engine.Dock = DockStyle.Fill;
            _engine.NavigationCompleted += OnWebViewNavigated;
            _store = store;
            _ = InitializeWebViewAsync();
        }

        public async Task InitializeWebViewAsync()
        {
            var options = new CoreWebView2EnvironmentOptions("--autoplay-policy=no-user-gesture-required");
            var environment = await CoreWebView2Environment.CreateAsync(null, null, options);
            await _engine.EnsureCoreWebView2Async(environment);
            Controls.Add(_engine);
            NotifyIcon.Visible = true;
            SelectItem(_store.SelectedItemId);
        }

        #endregion

        #region Form Handlers

        private void OnContextMenuAdd(object sender, EventArgs e)
        {
            var addItem = new StoreItem();
            using var editForm = new EditForm(addItem);
            if (editForm.ShowDialog() != DialogResult.OK) return;
            _store.Items.Add(addItem);
            _store.Save();
            SelectItem(addItem.Id);
        }

        private void OnContextMenuExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnContextMenuOpening(object sender, CancelEventArgs e)
        {
            if (sender is not ContextMenuStrip menu)
            {
                return;
            }

            for (var i = menu.Items.IndexOf(ContextMenuSeparator) + 1; i < menu.Items.Count;)
            {
                menu.Items.RemoveAt(i);
            }

            foreach (var item in _store.Items)
            {
                var menuItem = new ToolStripMenuItem(item.Name);
                menuItem.Checked = item.Id == _store.SelectedItemId;
                menuItem.MouseUp += (_, x) => ClickItem(x.Button, item, menu);
                menu.Items.Add(menuItem);
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            NotifyIcon.Text = Assembly.GetExecutingAssembly().FormatName();
        }

        #endregion

        #region Web Handlers

        private void OnWebViewInitialized(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!Debugger.IsAttached) return;
            _engine.CoreWebView2.OpenDevToolsWindow();
        }

        private void OnWebViewNavigated(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedItem?.Css)) return;
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FullscreenBrowserOverlay.Resources.InjectCss.js");
            using var reader = new StreamReader(stream ?? Stream.Null);
            var injectCssScript = reader.ReadToEnd();
            var injectCss = injectCssScript.Replace("[CSS]", HttpUtility.JavaScriptStringEncode(_selectedItem.Css));
            _ = _engine.CoreWebView2.ExecuteScriptAsync(injectCss);
        }

        #endregion

        #region Overrides of Form

        protected override CreateParams CreateParams
        {
            get
            {
                var @params = base.CreateParams;
                @params.ExStyle |= /*WS_EX_TOOLWINDOW*/ 0x80;
                return @params;
            }
        }

        #endregion
    }
}