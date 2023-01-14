namespace SubFix
{
    internal class OutputFile : InputFile
    {
        public string Content { get; set; }
        public OutputFile(string fullName, string name, string content) : base(fullName, name)
        {
            Content = content;
        }
    }
}
