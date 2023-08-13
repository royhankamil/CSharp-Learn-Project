using System;

namespace Program
{
    class ChapterOne:SyntaxGame
    {
        public short waktuTerbuang;
        public bool udahMakan;
        public int energi;
        public int mood;

        public ChapterOne()
        {
            Initialize();
            GetStarted();
            WakeUp();
        }

        private void GetStarted()
        {
            SelectingTwo("Mulai", "Ya", "Mulai");
        }

        private void Initialize()
        {
            waktuTerbuang = 0;
            udahMakan = false;
            energi = 200;
            mood = 100;
        }

        private void WakeUp()
        {
            string bangun;
            
            Console.Clear();
            GoTalk("...", time:400);
            GoTalk("Suatu saat aku bangun dari pagi yang terlihat cerah. aku mengerti hari ini adalah hari Minggu , yang mana hari", newline:false);
            GoTalk(" masih berbaring di tempat tidur yang sangat nyaman.");
            PeopleSay("Hari ini hari Minggu sangat malas sekali ...");
            bangun = SelectingTwo("Apakah kamu ingin bangun? ", "Bangun", "Tidur saja");
        
            if (bangun == "Tidur saja")
            {
                waktuTerbuang += 1;
                Console.Clear();
                PeopleSay("Sangat malas sekali, lebih enak tidur");
                GoTalk("Tilem", newline: false);
                GoTalk("...", time: 400);
                GoTalk("Beberapa jam kemnudian...");
                AfterWakeUp();
            }
            else
            {
                AfterWakeUp();
            }

        }

        private void AfterWakeUp()
        {
            string ngapain, kemana;
            Console.Clear();
            GoTalk("...", time: 400);
            GoTalk("uegghhh");
            GoTalk("*Membersihkan kasur");
            PeopleSay("Hari ini hari Minggu");
                
            ngapain = SelectingThree("Hmm enaknya ngapain ya?", "Pergi keluar", "Di dalam rumah", "Makan");
            if (ngapain == "Makan")
            {
                GoTalk("*Sedang membuat telor", 400);
                PeopleSay("Hmm nasib anak kost gini amat, kapan ya masakannya ada yang nyiapin?");
                Thread.Sleep(500);
                GoTalk("*Sedang makan", newline: false);
                GoTalk("...", 400);
                ngapain = SelectingTwo("lalu ngapain ya?", "Pergi keluar", "Di dalam rumah");
                udahMakan = true;
            }

            if (ngapain == "Pergi keluar")
            {
                PeopleSay("Sepertinya Minggu ini enaknya keluar");
                GoTalk("*Membuka pintu");
                PeopleSay("Hmmmm huuuh, suasananya sangat segar");
                
                kemana = SelectingThree("Hmm, enaknya kemana ya?", "Ke Taman", "Ke Perpus", "Ke Kuburan");
                if (kemana == "Ke Taman")
                {
                    PeopleSay("Kayaknya enakan ke taman aja dah");
                    PeopleSay("Suasanya mantap di taman");
                    TamanEvent();
                }
                else if (kemana == "Ke Perpus")
                {
                    PeopleSay("Menambah wawasan itu penting menurutku jadi lebih baik ke perpus");
                    PeopleSay("yah kayaknya lebih seru membaca novel dah");
                    PerpusEvent();
                }
                else if (kemana == "Ke Kuburan")
                {
                    PeopleSay("Udah lama gak ke kuburan");
                    PeopleSay("Ibu memutuhkan doa");
                    KuburanEvent();
                }
            }
            else if (ngapain == "Di dalam rumah")
            {
                PeopleSay("dah lah daripada keluar, nanti biaya lagi, mending dirumah aja");
                PeopleSay("Tapi di rumah ngapain??");
                Thread.Sleep(800);
                GoTalk("*suara handphone berdering");
                PeopleSay("Haloo");
                Console.Clear();
                PeopleSay("eh brooo, ikut aku ke luar", name:"Ucup");
                string ikut = SelectingTwo("Enaknya ikut apa gak?", "Ikut", "Malas");
                if (ikut == "Ikut")
                {
                    PeopleSay("Iya seh cup, aku ikut daripada di rumah");
                    PeopleSay("Okeh siip, aku tunggu di jalan biasanya...", name: "Ucup");
                    PeopleSay("Okeh...");
                    PerpusEvent(true);
                }
                else
                {
                    PeopleSay("Gak deh Cup, malas aku, mending tidur");
                    PeopleSay("tidur terus, ayolah sekali kali keluar rumah");
                    // PeopleSay("Gak ah");
                    while (true)
                    {
                        ikut = SelectingTwo("Ikut Gak?", "Ikut", "Malas");
                        if (ikut == "Ikut")
                        {
                            PeopleSay("Gak ah malas");
                            PeopleSay("Ayoolaah", name: "Ucup");
                        }
                        else
                        {
                            PeopleSay("Hamdeh maksa beut, yaudalah aku ikut");
                            PeopleSay("Okeh mantapp, aku tunggu di tempat biasanya...");
                            break;
                        }
                    }
                    PerpusEvent(true);
                }
            }

        }

        private void KuburanEvent()
        {
            string biarkan, bukaKuburan, kabur;

            Console.Clear();
            PeopleSay("Keliatannya aneh sih di hari Minggu bukan hari Jumat");
            PeopleSay("Tapi kalau Jumat malah gak bisa, yaudah lah Minggu aja");
            GoTalk("Suasana yang sepi dan cerah");
            Thread.Sleep(800);
            PeopleSay("Itu orang ngapain dah perilakunya kok aneh?");
            GoTalk("*Sedang mengubur sesuatu yang baunya tidak enak");
            biarkan = SelectingTwo("Biarin?", "Biarin aja", "Tanya");

            if (biarkan =="Tanya")
            {
                PeopleSay("Pak, pak lagi ngapain");
                PeopleSay("Bukan ini aku ngubur kucing mati", name: "???");
                PeopleSay("Tapi kok itu besar banget kucingnya? Baunya kok gini juga?");
                PeopleSay("Ini kucing terbaru, langka ini, bau bangkai memang gini", name: "???");
                PeopleSay("Jangan jangan bapak lagi ngubur orang");
                PeopleSay("Bukan ini kucing kok", name: "???");

                bukaKuburan = SelectingTwo("Coba buka kuburan?", "Buka", "Gausah");
                if (bukaKuburan == "Buka")
                {
                    GoTalk("*Membongkar kuburan...");
                    PeopleSay("Tuh kan tubuh manusia");
                    PeopleSay("Sttt gausah ngomong siapa-siapa atau kamu aku kubur juga kamu", name: "???");
                    GoTalk("*Ia menyembunyikan pisau di belakangnya");

                    kabur = SelectingTwo("Ingin kabur?", "Kabur...", "Lawan");

                    if (kabur == "Lawan")
                    {
                        PeopleSay("Itu perbuatan buruk bang");
                        PeopleSay("Mending serahin lu ke polisi");
                        PeopleSay("Gakkkk, aku gak mau dikurung!!!", name:"???");
                        GoTalk("*Melakukan penikaman terhadap Dudung");
                        Endings("Tertikam");
                    }
                    else{
                        GoTalk("*Dudung kabur...");
                        PeopleSay("Dah gila dunia ini, mendingan cabut...");
                        GoTalk("*bersembunyi...");
                        PeopleSay("huuh, sepertinya aman disini");
                        energi --;
                        mood-=20;
                        PeopleSay("Okeh aku aman sekarang, sepertinya aku bisa pulang...");
                        GoTalk("*Pulang...");
                        PulangDariKuburan();
                    }
                }
                else{
                    PeopleSay("Yaudah daripada sesuatu hal yang tidak diinginkan mending pergi aja");
                    PeopleSay("Oke deh bang aku pergi dulu");
                    PeopleSay("Baik", name:"???");
                    GoTalk("*Meninggalkan orang itu dan selesai mendoakan kerabat yang meninggal");
                    PeopleSay("Baikhlah aku pulang saja");
                    GoTalk("*Pulang...");
                    PulangDariKuburan();
                }
            }
            else{
                PeopleSay("Mungkin hanya perasaan ku saja");
                GoTalk("*Meninggalkan orang itu dan selesai mendoakan kerabat yang meninggal");
                PeopleSay("Baikhlah aku pulang saja");
                GoTalk("*Pulang...");
                PulangDariKuburan();
            }

        }

        private void PulangDariKuburan()
        {
            string belajar, refresh;

            Console.Clear();
            GoTalk("*Siang hari yang cerah sampai di rumah...");
            PeopleSay("hiuuh, akhirnya kembali ke rumah, agak melelahkan memang");
            
            belajar = SelectingTwo("Enaknya belajar apa gak ya?", "Belajar", "Tidak");
            if (belajar == "Belajar")
            {
                PeopleSay("Dah lah enak an belajar aja biar menambah wawasan");
                PeopleSay("Kayaknya belajar ngoding sabi sih");
                GoTalk("*3 jam kemudian", 550);
                Console.Clear();
                PeopleSay("ini maksudnya apa dah, halah kok gak bisa gituloh");
                PeopleSay("halah mending refresing aja dah");
            }
            else{
                PeopleSay("Lelah banget, malas belajar");
                waktuTerbuang -= 2;
            }

            refresh = SelectingThree("Mending ngapain ya?", "Makan", "Bermain game", "Mandi sore");
            if (refresh == "Makan")
            {
                PeopleSay("Mending makan lah, sepertinya saya lapar");
                GoTalk("*Makan roti...", 300);
                PeopleSay("Hmm sambil ngopi mantap juga nih");
            }
            else if (refresh == "Bermain game")
            {
                PeopleSay("Pusinggg mending main game");
                GoTalk("*Main game...", 300);
                waktuTerbuang--;
            }
            else if (refresh == "Mandi sore")
            {
                PeopleSay("Paling mantap mandi sih gebyor gebyor");
                GoTalk("*Mandi...", 300);
                PeopleSay("mbrrr, Segar coy");
            }

            Console.Clear();
            PeopleSay("Sepertinya aku belajar lagi");
            PeopleSay("Keliatannya melelahkan tapi terus ingat hasilnya...");
            PeopleSay("Semangat!!!");
            GoTalk("Belajar...", 300);
            GoTalk(" ", 500);

            Console.Clear();
            GoTalk("*Beberapa jam setelahnya");
            PeopleSay("Mungkin cukup itu aja pembelajarannya");
            PeopleSay("Tetap yakin bahwa kerja keras tak penah menghianati hasil");
            PeopleSay("Terus yakin pada prosesnya!!!");
            PeopleSay("Hargai proses, nikmati hasil");
            PeopleSay("*menguap, ini sudah waktunya tidur");
            Console.Clear();

            if (waktuTerbuang < 2)
            {
                PeopleSay("Aku cukup puas dengan hari ini, aku banyak belajar banyak hari ini");
                PeopleSay("Alhamdulillah, aku lega telah menyelesaikan tugas ku ini");
                GoTalk("*tidur...", 500);
                Endings("Banyak Belajar");
            }
            else
            {
                PeopleSay("Mengapa aku kok tadi main game ya?");
                PeopleSay("Seharusnya tadi aku belajar aja, masih banyak targetku yang belum selesai");
                PeopleSay("Padahal udah niatan belajar loh tadi");
                PeopleSay("Semoga besok lebih baik saja");
                Endings("Penyesalan");
            }

        }

        private void PerpusEvent(bool diajak = false)
        {
            string nongkrong, punyaMasalah, setuju, bisa;

            GoTalk("*Keluar rumah dan menuju perpustakaan");
            PeopleSay("Kayak nya seru dah kesana");
            if (diajak == true)
            {
                PeopleSay("Walaupun agak malas tapi yasudahlah, daripada di rumah ");
                PeopleSay("Hmm kayaknya bakalan lumayan seru");
            }

            else{
                GoTalk("*Ketika di jalan...");
                PeopleSay("Halooo, brooo", name:"Ucup");
                PeopleSay("Haloo bang");
                PeopleSay("Ahlan ahlan", name: "Ucup");
                PeopleSay("Mau ke perpus bro?");
                PeopleSay("Yoi barengan yuk?", name: "Ucup");
                PeopleSay("Okok");
            }

            GoTalk("*Setelah membaca cukup lama...", 500);
            nongkrong = SelectingTwo("Mau nongkrong gak brooh?", "Gasss", "Gak ah");
            if (nongkrong == "Gasss")
            {
                PeopleSay("Gass...");
                PeopleSay("Tapi enaknya ke mana ya... ");
                PeopleSay("Ke cafe Mescarre?", name: "Ucup");
                PeopleSay("Gass in aja dah");
            }
            else{
                PeopleSay("Mending jalan jalan aja");
                PeopleSay("Kemana?", name: "Ucup");
                PeopleSay("Kemana aja");
                PeopleSay("Yaudah jalan-jalan random aja", name: "Ucup");
            }

            PeopleSay("Brooh, sekarang lu punya kerjaan kah?");
            PeopleSay("Punya broh cuman aku pingin resign", name: "Ucup");
            PeopleSay("Kenapa dah? padahal enak gitu dah");
            PeopleSay("Anuu, aku malas boss nya galak banget", name: "Ucup");
            PeopleSay("Salahan dikasih tugas terus, gak ada istirahatnya", name: "Ucup");
            punyaMasalah = SelectingTwo("Lu punya masalah sama gak?", "Pasti", "Gak kok");
            if (punyaMasalah == "Pasti")
            {
                PeopleSay("Aku juga agak bingung karena, uang gaji masih kurang cukup untuk kehidupan sehari hari");
                PeopleSay("Tapi kayaknya ini memang masalah hidup yang pasti akan terjadi dah");
                PeopleSay("Benarr, tidak ada hidup tanpa masalah", name: "Ucup");
            }
            else{
                PeopleSay("Gak kok aku bahagia malahan");
                PeopleSay("Emang apa?", name: "Ucup");
            }
            Console.Clear();
            PeopleSay("Tapi seharusnya ada manfaat dan tujuan dari permasalahan ini");
            PeopleSay("Entahlah bro, aku gak mau terlalu berharap", name: "Ucup");
            PeopleSay("Aku heran, kok bisa ya orang-orang bisa sukses banget");
            PeopleSay("Mereka mempunyai caranya sendiri untuk sukses", name: "Ucup");
            PeopleSay("Banyak orang yang cerdas dalam memanipulasi orang lain", name: "Ucup");
            PeopleSay("Banyak orang pintar tetapi malah sering disuruh orang bodoh", name: "Ucup");
            PeopleSay("Seperti karyawan, mereka kebanyakan pintar tetapi sering disuruh-suruh oleh boss orang yang lebih bodoh", name: "Ucup");
            
            setuju = SelectingThree(" ", "Ya, itu benar", "Tidak menurutku", "Entahlah");
            if(setuju == "Ya, itu benar")
            {
                PeopleSay("Ya, memang itu benar");
            }
            else if (setuju == "Tidak menurutku")
            {
                PeopleSay("Menurutku tidak, karena boss itu pasti pernah menjadi karyawan");
                PeopleSay("Berarti dia orang yang pintar, dan tidak akan dipilih kalau dia bodoh");
                PeopleSay("Yah memang itu benar", name: "Ucup");
            }
            else{
                PeopleSay("Entahlah");
                PeopleSay("Mungkin benar");
            }

            bisa = SelectingTwo("Kamu udah bisa VueJs?", "Bisa", "Tidak");
            if (bisa == "Bisa")
            {
                PeopleSay("Bisa lah");
                PeopleSay("Yaudah kamu aja,", newline: false);
            }
            else{
                PeopleSay("Gak broh gak bisa aku");
                PeopleSay("Memangnya kenapa dah");
            }
            PeopleSay("Karena boss saya pingin menerima karyawan lagi", name: "Ucup");
            PeopleSay("Lah katae tadi ada masalah, kok malah nawarin");
            PeopleSay("Kali aja minat", name: "Ucup");
            Console.Clear();
            GoTalk("*Suara handphone berdering...", 500);
            PeopleSay("Haloo. Oh iya aku akan kesana...", name: "Ucup");
            PeopleSay("Yaudah bro, aku duluan, ada panggilan soalnya", name: "Ucup");
            PeopleSay("Okeh sampai jumpa lagi...");
            GoTalk("*menuju perjalanan pulang...", 500);
            PeopleSay("Lelah banget, gitu doang enaknya tidur di rumah");
            Kerumah();

        }

        private void TamanEvent()
        {
            string beriMakan, ajakBincang;

            Console.Clear();
            GoTalk("*Pergi ke taman...", 500);
            PeopleSay("Gilak suasananya mantep banget");
            mood+=10;
            GoTalk("Melihat lihat taman yang bagus");
            PeopleSay("hhmmmpp haah mantep banget");
            PeopleSay("Beuh ada kucing");
            PeopleSay("oh iya aku punya roti dengan daging");
            
            beriMakan = SelectingTwo("Beri makan kucing?", "Ya", "Gak");
            if (beriMakan == "Gak")
            {
                PeopleSay("Hmm kayaknya gak usah dah");
                GoTalk("*Beberapa jam kemudian...");
                PeopleSay("Dah lah mending kerumah aja dah");
                Kerumah();
            }

            else{
                Console.Clear();
                GoTalk("*Setelah beberapa menit kemudian");
                PeopleSay("Maaf ini kucing saya memang suka keluyuran", name:"???");
                PeopleSay("Oh kamu pemilik nya");
                PeopleSay("iya saya pemliknya", name:"???");
                PeopleSay("(Njir cewek coy)");

                Console.Clear();
                ajakBincang = SelectingTwo("Ajak berbincang", "Ayo", "Gausah");
                if (ajakBincang == "Gausah")
                {
                    PeopleSay("Okeh terima kasih ya mas", name:"???");
                    PeopleSay("Okeh mbak sama sama");
                    GoTalk("*Beberapa jam kemudian...");
                }
                else 
                {
                    PeopleSay("Mbaknya rumahnya deket sini a?");
                    PeopleSay("Iya ndek perempatan sana", name:"???");
                    PeopleSay("Kalo masnya rumahnya dimana", name:"???");
                    PeopleSay("Agak jauh dari sini sih");
                    
                    string ajakKenalan = SelectingTwo("Ajak kenalan?", "Gasin", "Gausah");
                    if(ajakKenalan == "Gasin")
                    {
                        PeopleSay("Kenalin namaku dudung, nama kamu siapa?");
                        PeopleSay("Namaku Bunga, salam kenal");

                        PeopleSay("Kamu pecinta kucing");
                        PeopleSay("Ya, aku sangat menyukai kucing", name:"Bunga");
                        PeopleSay("Aku punya 4 kucing di rumah", name:"Bunga");
                        PeopleSay("Cukup banyak ya...");
                        Console.Clear();
                        PeopleSay("Yang paling kamu sukai yang mana?");
                        PeopleSay("Kucing favoritku yang warnanya oren, dia tingkahnya lucu", name: "Bunga");
                        PeopleSay("Dia setiap pagi membangunkanku, seing mengeong", name: "Bunga");
                        PeopleSay("Sepertinya menarik untuk mempunyai kucing");
                        PeopleSay("Yah memang seperti itu", name: "Bunga");
                        PeopleSay("Aku menyukai binatang terutama kucing", name: "Bunga");
                        PeopleSay("Mereka layak untuk hidup, tetapi manusia banyak yang merusaknya", name: "Bunga");
                        ajakBincang = SelectingTwo(" ", "Yah itu benar", "Tidak menurutku");
                        if (ajakBincang == "Yah itu benar")
                        {
                            PeopleSay("Manusia memang seperti itu, sangat egois");
                            PeopleSay("Terkadang aku juga ingin merubah perilaku itu");
                            PeopleSay("Tetapi itu sangat sulit");
                        }
                        else{
                            PeopleSay("Entahlah memang itu lah kehidupan, ada masanya kejayaan");
                            PeopleSay("Ada masanya kita runtuh");
                        }
                        PeopleSay("Kamu benar", name:"Bunga");
                        mood += 40;

                    }
                    
                    PeopleSay("Hei Bunga...", name:"???");
                    PeopleSay("iyah aku akan kesana", name:"Bunga");
                    PeopleSay("Sepertinya aku sudah dicari aku duluan ya", name:"Bunga");
                    PeopleSay("Okeh sampai jumpa lain waktu");
                }

                ajakBincang = SelectingTwo("Pergi??", "Kerumah", "Merenung dulu");

                if (ajakBincang == "Kerumah")
                {
                    PeopleSay("Dah lah pulang aja aku");
                    PeopleSay("Sepertinya sudah sangat melelahkan");
                    GoTalk("*Kerumah...", 500);
                    Kerumah();
                }
                else{
                    Console.Clear();
                    PeopleSay("Dia kok sangat cantik?");
                    PeopleSay("Ahh gak dah gak, aku gak cinta, aku hanya memuji ciptaan Allah");
                    PeopleSay("Entahlah hari ini sangat menarik sekali aku bertemu dengannya");
                    GoTalk("*Perjalanan pulang...", 500);
                    PeopleSay("Memangnya aku bisa bertemu dengannya lagi??");
                    PeopleSay("Sepertinya tidak...");
                    mood+=20;
                    Console.Clear();
                    PeopleSay("Aku kembali kerumah...");
                    PeopleSay("Memang sangat menyedihkan hidup sendiri dalam kost");
                    GoTalk("*Menuju tempat tidur...", 500);
                    GoTalk("*Tidur...", 500);
                    Endings("Great Mood");
                }

            }

        }

        private void Kerumah()
        {
            string belajar, refresh, refresing;

            Console.Clear();
            GoTalk("*Siang hari yang cerah sampai di rumah...");
            PeopleSay("hiuuh, akhirnya kembali ke rumah, agak melelahkan memang");
            
            belajar = SelectingTwo("Enaknya belajar apa gak ya?", "Belajar", "Tidak");
            if (belajar == "Belajar")
            {
                PeopleSay("Dah lah enak an belajar aja biar menambah wawasan");
                PeopleSay("Kayaknya belajar ngoding sabi sih");
                GoTalk("*3 jam kemudian", 550);
                Console.Clear();
                PeopleSay("ini maksudnya apa dah, halah kok gak bisa gituloh");
                PeopleSay("halah mending refresing aja dah");
                // PeopleSay("Mending keluar rumah dah");
                refresing = SelectingTwo("Refresing?", "Gasss", "Lanjut belajar");
                if (refresing == "Lanjut belajar")
                {
                    GoTalk("*Beberapa jam kemudian...");
                    PeopleSay("Hamdeh ngantuk banget coy");
                    Endings("Ketiduran");
                }
            }
            else{
                PeopleSay("Lelah banget, malas belajar");
                GoTalk("*Main game...");
                PeopleSay("Dah lah bosen main game terus");
                waktuTerbuang -= 2;
            }

            Console.Clear();
            GoTalk("*Keluar rumah");
            GoTalk("*Lalu ke BetaMart");
            PeopleSay("Agak haus...");
            refresh = SelectingThree("Membeli minuman kayaknya sabi", "Teh pucuk", "Kopi kapal api", "Milku");
            if (refresh == "Teh pucuk")
            {
                PeopleSay("Teh pucuk, awet nih seger pula");
                PeopleSay("Nih mbak");
                PeopleSay("Terima kasih", name: "Kasir");
                GoTalk("*Minum...", 500);
            }
            else if (refresh == "Kopi kapal api")
            {
                PeopleSay("Ngilangin ngantuk sabi...");
                GoTalk("*Slurpp", 500);
                energi++;
            }
            else if (refresh == "Milku")
            {
                PeopleSay("Kata mama susu bikin nambah tinggi badan");
                GoTalk("*Minum...", 300);
                PeopleSay("Dah dikit banget isinya");
            }

            GoTalk("*Perjalanan ke rumah...", 500);
            string nyapa = SelectingTwo("Beuh ada si Daus tuh sapa gak ya?", "Sapa", "Pura pura tidak tau");
            if (nyapa == "Sapa")
            {
                PeopleSay("Ehh Us");
                PeopleSay("OH iya, dung", name:"Daus");
                PeopleSay("Abis darimana", name:"Daus");
                PeopleSay("Beli minuman aja sih");
                PeopleSay("Okeh aku duluan ya");
                PeopleSay("Oh iya...", name:"Daus");
            }
            else{
                PeopleSay("*menengok ke bawah, pura pura tidak tau");
            }

            Thread.Sleep(300);
            Console.Clear();
            PeopleSay("Sepertinya aku harus belajar lagi");
            PeopleSay("Keliatannya melelahkan tapi terus ingat hasilnya...");
            PeopleSay("Semangat!!!");
            GoTalk("Belajar...", 500);
            GoTalk(" ", 500);

            Console.Clear();
            GoTalk("*Beberapa jam setelahnya");
            PeopleSay("Mungkin cukup itu aja pembelajarannya");
            PeopleSay("Tetap yakin bahwa kerja keras tak penah menghianati hasil");
            PeopleSay("Terus yakin pada prosesnya!!!");
            PeopleSay("Hargai proses, nikmati hasil");
            PeopleSay("*menguap, ini sudah waktunya tidur");
            Console.Clear();

            if (waktuTerbuang < 2)
            {
                Thread.Sleep(400);
                Console.Clear();
                PeopleSay("Memang banyak ya cara orang lain untuk meraih kesuksesan");
                PeopleSay("Yang penting aku harus yakin!!!");
                PeopleSay("Pasti mudah ini mah...");
                PeopleSay("Esok hari pasti lebih baik daripada sekarang");
                GoTalk("*Tertidur");
                Endings("Berkawan");
            }
            else
            {
                PeopleSay("Mengapa aku kok tadi main game ya?");
                PeopleSay("Seharusnya tadi aku belajar aja, masih banyak targetku yang belum selesai");
                PeopleSay("Padahal udah niatan belajar loh tadi");
                PeopleSay("Semoga besok lebih baik saja");
                Endings("Penyesalan");
            }

        }

        private void Endings(string theEnding)
        {
            Console.Clear();
            if (theEnding == "Tertikam")
            {
                GoTalk("\t\t", 300, newline:false);
                GoTalk("TERTIKAM ENDING", 800);
                GoTalk("Dudung tertikam oleh sosok orang yang melakukan kejahatan. Semenjak itu pembunuhan berantai semakin ditakuti orang.", newline:false);
                GoTalk(" Oleh karena itu kita harus bijak dan cerdas dalam memutuskan suatu perkara. Terkadang telalu ikut urusan orang lain itu tidak baik.");

                GoTalk("\n\n\nBy Achmad Royhan Kamil...", 500);
            }
            
            else if (theEnding == "Banyak Belajar")
            {
                GoTalk("\t\t", 300, newline:false);
                GoTalk("BANYAK BELAJAR ENDING", 800);
                GoTalk("Dudung banyak belajar dan ia cukup puas dengan itu karena banyak tugasnya yang selesai. Ia tidak menyesal waktunya terbuang untuk belajar.", newline:false);
                GoTalk(" Ia juga dapat membagi waktu sehingga ia dapat sukses kedepannya.");

                GoTalk("\n\n\nBy Achmad Royhan Kamil...", 500);
            }
            
            
            else if (theEnding == "Penyesalan")
            {
                GoTalk("\t\t", 300, newline:false);
                GoTalk("PENYESALAN ENDING", 800);
                GoTalk("Dudung jauh lebih banyak bermain dan membuang buang waktu. Tugasnya banyak yang belum selesai. Hidupnya kurang lega", newline:false);
                GoTalk(" Karena ia mengambil haknya terlebih dahulu sebelum kewajiban. Maka ia keesokan harinya harus menyelesaikan kewajibannya");

                GoTalk("\n\n\nBy Achmad Royhan Kamil...", 500);
            }

            
            
            else if (theEnding == "Ketiduran")
            {
                GoTalk("\t\t", 300, newline:false);
                GoTalk("KETIDURAN ENDING", 800);
                GoTalk("Dudung banyak belajar tetapi ia tidak dapat membagi waktunya untuk beristirahat. Ia terlalu lelah sampai ia tertidur di depan laptop", newline:false);
                GoTalk(" Belajar boleh tetapi terlalu berlebihan tidaklah baik.");

                GoTalk("\n\n\nBy Achmad Royhan Kamil...", 500);
            }

            
            else if (theEnding == "Berkawan")
            {
                GoTalk("\t\t", 300, newline:false);
                GoTalk("BERKAWAN ENDING", 800);
                GoTalk("Dudung telah akrab dengan kawannya sehingga moodnya bagus. Selain itu ia juga banyak belajar tentang argumen tentang orang yang sukses.", newline:false);
                GoTalk(" Ia berpendirian untuk menjadi orang yang sukses.");

                GoTalk("\n\n\nBy Achmad Royhan Kamil...", 500);
            }
            
            
            else if (theEnding == "Great Mood")
            {
                GoTalk("\t\t", 300, newline:false);
                GoTalk("GET LOVE ENDING", 800);
                GoTalk("Dudung telah bertemu dengan wanita yang ia jatuh cintai. Tetapi ia sadar bayak hal yang tidak mungkin dan yang mungkin.", newline:false);
                GoTalk(" Tetapi Kemungkinannya sangat kecil sekali. Tetapi ia sudah berani mencoba.");

                GoTalk("\n\n\nBy Achmad Royhan Kamil...", 500);
            }
            else{
                GoTalk("Maksud anda???");
            }
        }

    }
}