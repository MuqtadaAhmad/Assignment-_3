using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_1
{
    internal class Account
    {
        public string userName;
        public string password;
        //public string UserName
        //{
        //    get { return userName; }
        //}
        //public string Password
        //{
        //    get { return Password; }
        //}

        public Account(Account ac)
        {
            this.userName = ac.userName;
            this.password = ac.password;
        }
        public Account(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
