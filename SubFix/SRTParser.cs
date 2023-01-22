using System.Text.RegularExpressions;

namespace SubFix
{
    class SRTParser
    {
        // Parse srt file using regex.
        public static SRTSegment[] Parse(string file)
        {
            List<SRTSegment> segments = new List<SRTSegment>();
            Regex regex = new Regex(@"(?<number>\d+)\r\n(?<start>\S+)\s-->\s(?<end>\S+)\r\n(?<text>(.|[\r\n])+?)\r\n\r\n");
            MatchCollection match = regex.Matches(File.ReadAllText(file));
            foreach (Match m in match)
            {
                segments.Add(new SRTSegment()
                {
                    Number = m.Groups["number"].Value,
                    StartTime = m.Groups["start"].Value,
                    EndTime = m.Groups["end"].Value,
                    TextLines = Regex.Split(Regex.Replace(Regex.Replace(m.Groups["text"].Value, "{.*?}", String.Empty), "<.*?>", String.Empty), "\r\n"),
                    IsItalic = m.Groups["text"].Value.ToString().ToLower().StartsWith("<i>"),
                    IsUnderline = m.Groups["text"].Value.ToString().ToLower().StartsWith("<u>")
                });
            }
            return segments.ToArray();
        }
    }

    public class SRTSegment
    {
        public bool IsItalic { get; set; }

        public bool IsUnderline { get; set; }

        public string Number { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string[] TextLines { get; set; }
    }
}
