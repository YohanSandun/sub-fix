namespace SubFix
{
    internal interface Rule
    {
        SRTFile Apply(RuleConfiguration config, SRTFile file);
    }
}
