using FullscreenBrowserOverlay.Entities;

namespace FullscreenBrowserOverlay
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var store = Store.LoadOrDefault();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(store));
        }
    }
}