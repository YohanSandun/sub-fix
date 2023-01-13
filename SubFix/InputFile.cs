using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubFix
{
    internal class InputFile
    {
        public string FullName { get; set; }
        public string Name { get; set; }

        public InputFile(string fullName, string name)
        {
            FullName = fullName;
            Name = name;
        }
    }
}
