using Microsoft.Win32;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace SubFixFontInstaller
{
    internal class FontInstaller
    {
        [DllImport("gdi32", EntryPoint = "AddFontResource")]
        public static extern int AddFontResourceA(string lpFileName);
        [DllImport("gdi32.dll")]
        private static extern int AddFontResource(string lpszFilename);
        [DllImport("gdi32.dll")]
        private static extern int CreateScalableFontResource(uint fdwHidden, string
            lpszFontRes, string lpszFontFile, string lpszCurrentPath);

        public static void RegisterFont(string contentFontName)
        {
            // Creates the full path where your font will be installed
            var fontDestination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), contentFontName);

            if (!File.Exists(fontDestination))
            {
                // Copies font to destination
                System.IO.File.Copy(Path.Combine(Directory.GetCurrentDirectory(), contentFontName), fontDestination);

                // Retrieves font name
                // Makes sure you reference System.Drawing
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(fontDestination);
                var actualFontName = fontCol.Families[0].Name;

                //Add font
                AddFontResource(fontDestination);
                //Add registry entry   
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts", actualFontName, contentFontName, RegistryValueKind.String);
            }
        }
    }
}
