using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello"); // output 
            Console.Write("masukkan angka untuk menjadi kuadrat: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            int hasil = (int)Math.Pow(integer, 2); // untuk pangkat
            Console.WriteLine(hasil);

            Console.WriteLine(Math.Abs(-34.8));
            Console.WriteLine(Math.Round(-35.3));
            Console.WriteLine(Math.Round(Math.Abs(-35.3)));

            // //kutip yang pertama adalah untuk pembuka kutip yang kedua yang didalam kutip dianggap string kutip
            // //di program ""isinya"" menjadi di output "isinya"
            Console.WriteLine(@"file:C:system\hello\audio  ""Sekarang hari jumat"""); 

            int absen = 1;
            string nama = "Royhan";
            string namaBelakang = "Kamil";
            string namaLengkap = nama + namaBelakang; // concat juga bisa di console
            Console.WriteLine($"Halooo nama saya {nama} saya absen {absen}\n"); // interpolation
            Console.WriteLine($@"Halooo nama saya ""{nama}"" saya absen ""{absen}""");
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // menggunakan unicode

            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");

            string projectName = "ACME";
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n");

            //// string methods
            string mobil = "Mustang";
            Console.WriteLine($"{mobil} dan huruf \"t\" pada indeks: {mobil.IndexOf('t')}"); // 3
            Console.WriteLine($"{mobil} indeks ke 5 adalah: {mobil[5]}"); // n
            Console.WriteLine($"{mobil} indeks ke 0 adalah: {mobil[0]}"); // M

            
            string[] bulan = new string[] {"January", "Februari", "Maret", "April", "Mei", 
            "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"};
            string[] hari;
            hari = new string[] {"Ahad", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"};

            Console.WriteLine($"bulan itu ada {bulan.Length} dengan bulan pertamanya {bulan[0]}");
            // Array.Find akan mencari syarat syarat tertentu apabila ditemukan langsung direturn
            // hanya bisa satu return dan yang pertama yang akan direturn
            string longSong = Array.Find(bulan, song => song.Length > 5); 

            Console.WriteLine(longSong);

        }
    }
}