using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV0
{
    internal class CustomLogin : Login
    {
        public CustomLogin(string username, string password) : base(username, password)
        {
        }

        public override bool Authenticate()
        {


            return false;
        }
    }
}