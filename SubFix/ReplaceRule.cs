namespace SubFix
{
    internal class ReplaceRule : Rule
    {
        class ReplaceItem
        {
            public string Find { get; set; }
            public string Replace { get; set; }

            public ReplaceItem(string find, string replace)
            {
                Find = find;
                Replace = replace;
            }
        }

        private List<ReplaceItem> items = new List<ReplaceItem>();

        public ReplaceRule()
        {
            items.Add(new ReplaceItem("ා", "ා "));
            items.Add(new ReplaceItem("ැ", "ැ "));
            items.Add(new ReplaceItem("ෑ", "ෑ "));
            items.Add(new ReplaceItem("ො", "ො "));
            items.Add(new ReplaceItem("ෝ", "ෝ "));
            items.Add(new ReplaceItem("ෞ", "ෞ "));
            items.Add(new ReplaceItem("ෟ", "ෟ "));
            items.Add(new ReplaceItem("ෲ", "ෲ "));
            items.Add(new ReplaceItem("ෳ", "ෳ "));
            items.Add(new ReplaceItem("ෘ", "ෘ "));
        }

        public string Apply(string text)
        {
            foreach (ReplaceItem item in items)
                text = text.Replace(item.Find, item.Replace);
            return text;
        }
    }
}
