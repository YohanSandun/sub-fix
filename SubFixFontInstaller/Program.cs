using SubFixFontInstaller;

try
{
    FontInstaller.RegisterFont("UN-Bindumathi.ttf");
    Console.WriteLine("Done");
}
catch (Exception ex)
{
    Console.WriteLine("Error installing the font!\n\n" + ex.Message);
}
