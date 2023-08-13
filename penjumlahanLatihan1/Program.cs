/* latihan 1 : membuat inputan penjumlahan  */
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //// percobaan 
            // Console.WriteLine('a');
            // Console.WriteLine("Hello peserta SMK Coding");
            // Console.WriteLine(123);
            // Console.WriteLine(77.5m);
            // Console.WriteLine(true);
            // Console.WriteLine(false);

            // string namaDepan = "Bob";
            // int messages = 1;
            // decimal temperature = 34.4m;
            // bool isRain = true;

            // Console.Write("Hello, ");
            // Console.Write(namaDepan);
            // Console.Write("\n! Anda Memiliki ");
            // Console.Write(messages);
            // Console.Write(" pesan pada inbox anda. Temperature nya adalah ");
            // Console.Write(temperature);
            // Console.Write(" celcius, hari ini cuacanya hujan ");
            // Console.Write(isRain);
            
            // var messages = 23;
            // Console.Write(messages);


        

            ///////////////////   latihan 1      ////////////////////
            //declaration
            int a, b, hasil; 
            Console.Write("Masukkan angka ke-1: ");
            a = Convert.ToInt32(Console.ReadLine()); // must be convert because by default readline is a string
            Console.Write("Masukkan angka ke-2: ");
            b = Convert.ToInt32(Console.ReadLine());// must be convert because by default readline is a string
            hasil = a+b;
            Console.Write("Hasilnya adalah : " + hasil);
            
        }
    }
}

