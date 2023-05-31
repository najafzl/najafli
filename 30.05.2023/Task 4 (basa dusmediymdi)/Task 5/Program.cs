namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] reqemler1 = { 4, 5, 2, 6, 4, 3 };
            int[] reqemler2 = { 7, 4, 2, 76, 45, 65 };

            var ferqlireqemler = reqemler1.Except(reqemler2);

            Console.WriteLine("\nBirinci arrayda olan ikinci arrayda olmuyan elementder: \n");
            foreach (var Ferqli in ferqlireqemler)
            {
                Console.Write($" {Ferqli} ");
            }
            Console.WriteLine("");
        }
    }
}