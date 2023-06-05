namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maaslar = new int[5];
            int count = 5;
            int edediorta = 0;

            Engineer engineer = new Engineer();
            Employee employee = new Employee("Ehmed Haciyev", "Yusif Eliyev", "Ruslan Huseynov", "Kamil Memmedov", "Necef Necefli");

            for (int i = 0; i < maaslar.Length; i++)
            {
                Console.WriteLine($"\nZehmet olmasa {i + 1}.Iscinin maasini daxil edin: ");
                Console.Write("\n");
                maaslar[i] = Convert.ToInt32(Console.ReadLine());
                if (maaslar[i] < 300)
                {
                    employee.IscilerinMaasi();
                    break;
                }
                edediorta += maaslar[i] / count;
            }
                engineer.IscilerinHesabi();
        }
    }
}