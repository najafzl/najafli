namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            while (user.USERNAME == null || user.USERNAME.Length < 8)
            {
                Console.Write("Istifadeci adinizi daxil edin (en az 8 herf olmalidir): ");
                user.USERNAME = Console.ReadLine();
            }

            while (user.PASSWORD == null || user.PASSWORD.Length < 8 || !boyukherfvarmidir(user.PASSWORD) || !kicikherfvarmidir(user.PASSWORD) || !reqemvarmidir(user.PASSWORD))
            {
                Console.Write("Parolunuzu daxil edin (parolunuzda en azi 1 kicik herf, bir boyuk herf ve reqem olmalidir): ");
                user.PASSWORD = Console.ReadLine();
            }

            Console.WriteLine("\nHesabiniz:");
            Console.WriteLine("\nIstifadeci adiniz: " + user.USERNAME);
            Console.WriteLine("\nParolunuz: " + user.PASSWORD);
        }

        static bool boyukherfvarmidir(string deyeriyoxlama)
        {
            return deyeriyoxlama.Any(char.IsUpper);
        }

        static bool kicikherfvarmidir(string deyeriyoxlama)
        {
            return deyeriyoxlama.Any(char.IsLower);
        }

        static bool reqemvarmidir(string deyeriyoxlama)
        {
            return deyeriyoxlama.Any(char.IsDigit);
        }
    }
}
