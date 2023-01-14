namespace SubFix
{
    internal class RulesContext
    {

        private List<Rule> _rules = new List<Rule>();

        public void AddRule(Rule rule)
        {
            _rules.Add(rule);
        }

        public string ApplyRules(string text)
        {
            for (int i = 0; i < _rules.Count; i++)
            {
                text = _rules[i].Apply(text);
            }

            return text;
        }

    }
}
