namespace SubFix
{
    internal interface RuleConfiguration
    {

    }

    public class FontAddRuleConfiguration : RuleConfiguration
    {

        public string FontName { get; set; }

        public FontAddRuleConfiguration(string fontName)
        {
            FontName = fontName;
        }
    }
}
