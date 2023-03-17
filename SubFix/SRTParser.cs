using System.Diagnostics;
using System.Text;

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
        private int _line;
        private char _currentChar;
        private char[] _text;
        private bool _hasError = false;
        public string ErrorDetails { get; set; }

        public SRTParser(string fileName)
        {
            ErrorDetails = "";
            _index = -1;
            _line = 1;
            _text = File.ReadAllText(fileName).Replace("\r\n", "\n").ToCharArray();
            _advance();
        }

        public SRTFile Parse()
        {
            List<SRTSegment> segments = new List<SRTSegment>();

            while (_currentChar != '\0')
            {
                skipNewLines();

                if (_currentChar >= '0' && _currentChar <= '9')
                {
                    segments.Add(_parseSegment());
                }
                else
                {
                    Debug.WriteLine(segments[segments.Count-2].ID);
                    ErrorDetails = "Expected ID at line " + _line;
                    return new SRTFile(true);
                }
            }
            if (_hasError)
                return new SRTFile(true);

            return new SRTFile(segments);
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
                _hasError = true;
                ErrorDetails = "Expected new line after ID at line " + _line;
                return null;
            }
            _advance();

            // Parsing the time by just skipping until the end of line
            string time = _matchUntilNewLine();
            _advance();

            // Parsing the content by just skipping until two new lines
            string content = _matchUntilDoubleNewLine();

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
                    _hasError = true;
                    ErrorDetails = "Expected new line after time at line " + _line;
                    return "";
                }
            }

            return sb.ToString();
        }

        private void skipNewLines()
        {
            while (_currentChar == '\n' || _currentChar == ' ' || _currentChar == '\t')
                _advance();
        }

        private string _matchUntilDoubleNewLine()
        {
            StringBuilder sb = new StringBuilder();

            while (_currentChar != '\0')
            {
                if (_currentChar == '\n' && _peek() == '\n')
                {
                    _line += 2;
                    _advance(2);
                    while (_currentChar == '\n')
                        _advance();

                    return sb.ToString();
                }

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
            if (_currentChar == '\n' && num == 1)
                _line++;

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
        public bool HasError { get; } = false;

        public SRTFile(List<SRTParser.SRTSegment> segments)
        {
            Segments = segments;
        }

        public SRTFile(bool error)
        {
            HasError = error;
            Segments = new List<SRTParser.SRTSegment>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SRTParser.SRTSegment segment in Segments)
                sb.Append(segment.ToString());
            return sb.ToString();
        }
    }
}
