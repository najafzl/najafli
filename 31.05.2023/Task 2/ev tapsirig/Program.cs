using ev_tapsirig;

namespace elebele
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName, groupNo;
            int age;

            while (true)
            {
                Console.Write("\nAdinizi ve Soyadinizi daxil edin: ");
                fullName = Console.ReadLine();            

                Console.Write("\nQrup nomrenizi daxil edin: ");
                groupNo = Console.ReadLine();

                if (!Student.CheckGroupNo(groupNo))
                {
                    Console.WriteLine("\nZehmet olmasa qrup nomrenizi duzgun daxil edin. meselucun (P216)");
                    continue;
                }

                Console.Write("Yasini daxil et: ");
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("\nYasi duzgun daxil etmediz xahis olunur duzgun daxil eidn.");
                    continue;
                }

                break;
            }
            Student student = new Student
            {
                FullName = fullName,
                GroupNo = groupNo,
                Age = age
            };
            Console.WriteLine("Sagird ugurla qydiyattan kecdi: \n *****************\n");
            Console.WriteLine($"Full Name: {student.FullName}");
            Console.WriteLine($"Group Nomresi: {student.GroupNo}");
            Console.WriteLine($"Yasi: {student.Age}");
        }
    }
}    
    

