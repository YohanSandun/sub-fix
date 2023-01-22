namespace SubFix
{
    internal interface Rule
    {
        SRTFile Apply(SRTFile file);
    }
}
