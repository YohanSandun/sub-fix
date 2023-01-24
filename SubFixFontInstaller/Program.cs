using SubFixFontInstaller;

try
{
    FontInstaller.RegisterFont("UN-Bindumathi.ttf");
}
catch (Exception ex)
{
    Console.WriteLine("Error installing the font!\n\n" + ex.Message);
}
