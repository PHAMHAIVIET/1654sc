using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV0{
    internal class Subject
    {
        private string code;
        private string name;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Subject(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
