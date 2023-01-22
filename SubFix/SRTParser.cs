using System.Text;
using System.Text.RegularExpressions;

namespace SubFix
{
    class SRTParser
    {
        // Parse srt file using regex.
        public static SRTFile Parse(string file)
        {
            List<SRTSegment> segments = new List<SRTSegment>();
            Regex regex = new Regex(@"(?<number>\d+)\n(?<start>\S+)\s-->\s(?<end>\S+)\n(?<text>(.|[\n])+?)\n\n");
            MatchCollection match = regex.Matches(File.ReadAllText(file));
            foreach (Match m in match)
            {
                segments.Add(new SRTSegment()
                {
                    Number = m.Groups["number"].Value,
                    StartTime = m.Groups["start"].Value,
                    EndTime = m.Groups["end"].Value,
                    TextContent = m.Groups["text"].Value//Regex.Replace(Regex.Replace(m.Groups["text"].Value, "{.*?}", String.Empty), "<.*?>", String.Empty),
                });
            }
            return new SRTFile(segments);
        }
    }

    public class SRTSegment
    {
        public string Number { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string TextContent { get; set; }
    }

    public class SRTFile
    {
        public List<SRTSegment> Segments { get; set; }

        public SRTFile(List<SRTSegment> segments)
        {
            Segments = segments;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SRTSegment segment in Segments)
                sb.Append(segment.TextContent);
            return sb.ToString();
        }
    }
}
