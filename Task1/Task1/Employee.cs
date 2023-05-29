using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee
    {
        public string FullName;
        public string FullName2;
        public string FullName3;
        public string FullName4;
        public string FullName5;
        public string Salary;

        public void IscilerinMaasi()
        {
            Console.WriteLine("\n Iscilerin maasi 300-den asagi ola bilmez");
        }

        public Employee(string _FullName, string _fullName2, string _fullName3, string _fullName4, string _fullName5)
        {
            FullName = _FullName;
            FullName2 = _fullName2;
            FullName3 = _fullName3;
            FullName4 = _fullName4;
            FullName5 = _fullName5;
        }

    }
}
