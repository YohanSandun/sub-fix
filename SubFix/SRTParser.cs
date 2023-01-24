using System.Text;
using System.Text.RegularExpressions;

namespace SubFix
{
    public class SRTParser
    {
        public class SRTSegment
        {
            public string ID { get; set; }
            public string Content { get; set; }
            public string Time { get; set; }

            public SRTSegment(string iD, string content, string time)
            {
                ID = iD;
                Content = content;
                Time = time;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(ID);
                sb.Append('\n');
                sb.Append(Time);
                sb.Append('\n');
                sb.Append(Content);
                sb.Append("\n\n");

                return sb.ToString();
            }
        }

        private int _index;
        private char _currentChar;
        private char[] _text;

        public SRTParser(string fileName)
        {
            _index = -1;
            _text = File.ReadAllText(fileName).ToCharArray();
            _advance();
        }

        public List<SRTSegment> Parse()
        {
            List<SRTSegment> segments = new List<SRTSegment>();

            while (_currentChar != '\0')
            {
                if (_currentChar >= '0' && _currentChar <= '9')
                {
                    segments.Add(_parseSegment());
                }
                else
                {
                    //Console.WriteLine("Error: ID expected!");
                    return segments;
                }
            }

            return segments;
        }

        private SRTSegment _parseSegment()
        {
            StringBuilder idsb = new StringBuilder();
            idsb.Append(_currentChar);
            _advance();

            // Parsing the ID
            while (_currentChar >= '0' && _currentChar <= '9')
            {
                idsb.Append(_currentChar);
                _advance();
            }

            if (_currentChar != '\n')
            {
                //Console.WriteLine("Error : Expected new line after ID");
                return null;
            }
            _advance();

            // Parsing the time by just skipping until the end of line
            string time = _matchUntilNewLine();
            _advance();

            // Parsing the content by just skipping until two new lines
            string content = _matchUntilDoubleNewLine();
            _advance(2);

            return new SRTSegment(idsb.ToString(), content, time);
        }

        private string _matchUntilNewLine()
        {
            StringBuilder sb = new StringBuilder();

            while (_currentChar != '\n')
            {
                sb.Append(_currentChar);
                _advance();
                if (_currentChar == '\0')
                {
                    //Console.WriteLine("Expected new line after time");
                    return "";
                }
            }

            return sb.ToString();
        }

        private string _matchUntilDoubleNewLine()
        {
            StringBuilder sb = new StringBuilder();

            while (_currentChar != '\0')
            {
                if (_currentChar == '\n' && _peek() == '\n')
                    return sb.ToString();

                sb.Append(_currentChar);
                _advance();
            }

            return sb.ToString();
        }

        private char _peek(int num = 1)
        {
            if (_index + num < _text.Length)
                return _text[_index + num];
            else
                return '\0';
        }

        private void _advance(int num = 1)
        {
            _index += num;
            if (_index < _text.Length)
                _currentChar = _text[_index];
            else
                _currentChar = '\0';
        }
    }

    public class SRTFile
    {
        public List<SRTParser.SRTSegment> Segments { get; set; }

        public SRTFile(List<SRTParser.SRTSegment> segments)
        {
            Segments = segments;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SRTParser.SRTSegment segment in Segments)
                sb.Append(segment);
            return sb.ToString();
        }
    }
}
