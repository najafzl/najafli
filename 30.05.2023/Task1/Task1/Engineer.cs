using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Engineer
    {
        int[] maaslar = new int[5];
        int count = 5;
        int edediorta = 0;
        Employee employee = new Employee("Ehmed Haciyev", "Yusif Eliyev", "Ruslan Huseynov", "Kamil Memmedov", "Necef Necefli");
        public void IscilerinHesabi()
        {

            Console.WriteLine($"\n{employee.FullName}-in maasi: {maaslar[0]}");
            Console.WriteLine($"\n{employee.FullName2}-in maasi:{maaslar[1]}");
            Console.WriteLine($"\n{employee.FullName3}-in maasi: {maaslar[2]}");
            Console.WriteLine($"\n{employee.FullName4}-in maasi: {maaslar[3]}");
            Console.WriteLine($"\n{employee.FullName5}-nin maasi: {maaslar[4]}");
            Console.WriteLine($"\nIscilerin ortalama maasi: {edediorta}");
        }

    }
}
