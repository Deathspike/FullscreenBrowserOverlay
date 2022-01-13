using System.Reflection;

namespace FullscreenBrowserOverlay.Extensions
{
    public static class AssemblyExtensions
    {
        public static string FormatName(this Assembly assembly)
        {
            var name = assembly.GetName();
            return $"{name.Name} ({name.Version})";
        }
    }
}