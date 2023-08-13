using System;

namespace Program
{

    class Program
    {
        static void StartUI(string word)
        {
            string titik = "";
            for (int i =0; i < 15; i++)
            {
                Console.Clear();
                titik += ".";
                if (titik.Length > 3)
                    titik = "";
                Console.WriteLine(word + titik);
                Thread.Sleep(200);
            }

        }

        static void Main(string[] args)
        {
            StartUI("Now Loading");

            ChapterOne storysatu = new ChapterOne();

        }
    }
}
