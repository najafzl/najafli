using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class User
    {
        private string UserName;

        private string Password;

        public string USERNAME 
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
        public string PASSWORD
        {
            get
            {
                return Password;
            }
            set 
            { 
                Password = value; 
            }
        }
    }
}
