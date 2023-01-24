namespace SubFix
{
    internal class FontAddRule : Rule
    {
        public SRTFile Apply(SRTFile file)
        {
            //Iskoola Pota
            foreach (SRTParser.SRTSegment segment in file.Segments)
                segment.Content = "<font face=\"UN-Bindumathi\">" + segment.Content + "</font>";
            return file;
        }
    }
}
