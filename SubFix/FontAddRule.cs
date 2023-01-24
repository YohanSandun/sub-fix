namespace SubFix
{
    internal class FontAddRule : Rule
    {
        public SRTFile Apply(RuleConfiguration config, SRTFile file)
        {
            foreach (SRTParser.SRTSegment segment in file.Segments)
                segment.Content = "<font face=\""+((FontAddRuleConfiguration)config).FontName+"\">" + segment.Content + "</font>";
            return file;
        }
    }
}
