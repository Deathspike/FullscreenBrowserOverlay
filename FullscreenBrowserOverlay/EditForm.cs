using FullscreenBrowserOverlay.Entities;
using FullscreenBrowserOverlay.Extensions;
using System.Reflection;

namespace FullscreenBrowserOverlay
{
    public partial class EditForm : Form
    {
        private readonly StoreItem _item;

        #region Abstracts

        private void Success()
        {
            Close();
            DialogResult = DialogResult.OK;
        }

        #endregion

        #region Constructor

        public EditForm(StoreItem item)
        {
            InitializeComponent();
            _item = item;
        }

        #endregion

        #region Form Handlers

        private void OnFormLoad(object sender, EventArgs e)
        {
            CssBox.Text = _item.Css;
            NameBox.Text = _item.Name;
            UrlBox.Text = _item.Url;
            Text = Assembly.GetExecutingAssembly().FormatName();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrWhiteSpace(UrlBox.Text)) return;
            _item.Css = CssBox.Text;
            _item.Name = NameBox.Text.Trim();
            _item.Url = UrlBox.Text.Trim();
            Success();
        }

        #endregion
    }
}