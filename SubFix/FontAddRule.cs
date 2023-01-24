namespace SubFix
{
    internal class FontAddRule : Rule
    {
        public SRTFile Apply(SRTFile file)
        {
            foreach (SRTParser.SRTSegment segment in file.Segments)
                segment.Content = "<font face=\"Iskoola Pota\">" + segment.Content + "</font>";
            return file;
        }
    }
}
