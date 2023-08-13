using System;

namespace Program
{
    class program
    {
        static void Main(string[] args)
        {
            string nama, jawaban, alasan;
            int umur, indeks = 0;
            Console.Clear();
            Console.WriteLine("Haloo nama saya bothie, lalu kamu ? ");
            nama = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Haloo {nama}, senang bertemu denganmu");
            Thread.Sleep(5000);

            Console.Write("Ngomong ngomong kamu umur berapa ya?");
            umur = Convert.ToInt16(Console.ReadLine());
            if (umur < 8)
                Console.WriteLine("Wah!!! kamu masih kecil sekali, kamu keren");
            else if (umur < 14)
                Console.WriteLine("Kamu adalah seorang remaja, gunakan waktumu sebaik mungkin");
            else if (umur <20)
                Console.WriteLine("Kamu tau, kamu semakin dekat dengan impianmu ketika usia ini");
            else if (umur < 30)
                Console.WriteLine("JANGAN PATAH SEMANGAT, TERUS LAKUKAN YANG TERBAIK");
            else if (umur < 50)
                Console.WriteLine("Kamu mungkin butuh ketenangan");
            else if (umur == null)
                Console.WriteLine("mengapa kamu diam saja");
            else 
                Console.WriteLine("Sangat terhormat bertemu dengan anda");
            
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Hidup memang belum tentu sesuai dengan harapan ya? ");
            jawaban = Console.ReadLine();

            if (jawaban == "tidak" || jawaban== "t" || jawaban == "ngak" )
            {
                Console.Write("mengapa tidak ? ");
                alasan = Console.ReadLine();
                Console.WriteLine("yah, mungkin kamu benar");
            }
            Thread.Sleep(5000);

            Console.Write("Apakah rumahmu jauh? ");
            jawaban = "";
            jawaban = Console.ReadLine();
            if (jawaban == "tidak" || jawaban == "deket" || jawaban=="deket kok" || jawaban == "t")
                Console.WriteLine("Berarti dekat sini dong, hmm dimana yah rumahmu...");
            else if (jawaban == "ya" || jawaban == "y" || jawaban == "benar")
                Console.WriteLine("Hmm jauh ");
            else
                Console.WriteLine("Hmm...");
            Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.WriteLine("ohh sepertinya aku sudah dicari");
            Thread.Sleep(1000);
            Console.WriteLine($"senang bertemu denganmu {nama} sampai jumpa");
            Console.WriteLine("Mungkin kapan kapan kita bertemu lagi");

            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(800);
                Console.Write("*");
            }
                Console.WriteLine();
            Console.WriteLine("\t\tterima kasih");
            while (indeks < 30)
            {
                indeks++;
                Thread.Sleep(800);
                Console.Write("*"); 
            }
                Console.WriteLine();  
        }
    }
}
