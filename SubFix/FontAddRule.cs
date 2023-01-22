namespace SubFix
{
    internal class FontAddRule : Rule
    {
        public SRTFile Apply(SRTFile file)
        {
            foreach (SRTSegment segment in file.Segments)
            {
                segment.TextContent = "<font face=\"Iskoola Pota\">" + segment.TextContent + "</font>";
            }
            return file;
        }
    }
}
