namespace Task5
{
    class Program
    {
        static void Main()
        {
            int[] reqemler = { 7, 6, 4, 86 ,45, 21, 90, 200, 321, 19, 35,76542 };

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