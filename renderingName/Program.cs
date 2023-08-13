using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nama = {"Farhan", "Adi", "Saputro", "Saiful", "Dadang", "Raffi"};
            Console.WriteLine($"Nama data ada {nama.Length}");

            foreach(string i in nama)
            {
                for(int j=0; j<i.Length; j++)
                {
                    Thread.Sleep(200);
                    Console.Write(i[j]);
                }
                Console.WriteLine();
            }

        }
    }
}
