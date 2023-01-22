namespace SubFix
{
    internal class RulesContext
    {

        private List<Rule> _rules = new List<Rule>();

        public void AddRule(Rule rule)
        {
            _rules.Add(rule);
        }

        public SRTFile ApplyRules(SRTFile file)
        {
            for (int i = 0; i < _rules.Count; i++)
            {
                file = _rules[i].Apply(file);
            }
            return file;
        }

    }
}
