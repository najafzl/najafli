namespace Task5
{
    class Program
    {
        static void Main()
        {
            int[] reqemler = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] cutreqemler = cutededlerial(reqemler);

            Console.WriteLine("Bu arraydeki cut ededler:\n");
            foreach (int Cut in cutreqemler)
            {
                Console.WriteLine(Cut);
            }
        }

        static int[] cutededlerial(int[] Reqemler)
        {
            int cutededlerinsayi = 0;
            for (int i = 0; i < Reqemler.Length; i++)
            {
                if (Reqemler[i] % 2 == 0)
                {
                    cutededlerinsayi++;
                }
            }

            int[] Evennumbers = new int[cutededlerinsayi];
            int ii = 0;

            for (int i = 0; i < Reqemler.Length; i++)
            {
                if (Reqemler[i] % 2 == 0)
                {
                    Evennumbers[ii] = Reqemler[i];
                    ii++;
                }
            }
            return Evennumbers;

}   }   }           