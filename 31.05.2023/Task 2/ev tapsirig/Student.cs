using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_tapsirig
{
    public class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int Age { get; set; }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3])) 
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}
