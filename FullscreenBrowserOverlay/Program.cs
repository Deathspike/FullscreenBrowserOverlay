using FullscreenBrowserOverlay.Entities;

namespace FullscreenBrowserOverlay
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            using var mutex = new Mutex(true, "{7675EE47-C9A1-4C62-BF13-D76B1343E9CA}");
            if (!mutex.WaitOne(TimeSpan.Zero, true)) return;
            var store = Store.LoadOrDefault();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(store));
            mutex.Dispose();
        }
    }
}