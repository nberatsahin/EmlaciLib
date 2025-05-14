using System.Net.WebSockets;
using EmlaciLib;
namespace classApp

{
    internal class Program
    {
        static void Main(string[] args)
        {


            SatilikEv se = new SatilikEv(500, 3, 3, "satılık ev", 250);
            SatilikEv se1 = new SatilikEv(200, 2, 1, "satılık ev", 550);
            SatilikEv se2 = new SatilikEv(340, 5, 0, "satilik ev", 340);

            KiralikEv ke = new KiralikEv(300, 300, 5, 2, "kiralık ev", 90);
            KiralikEv ke1 = new KiralikEv(350, 350, 1, 7, "kiralık ev", 600);
            KiralikEv ke2 = new KiralikEv(1200, 200, 1, 3, "kiralık ev", 300);
            Ev[] evs = {se, se1, se2, ke, ke1, ke2};
            for (int i = 0; i < evs.Length; i++)
            {
                //if (evs[i] is SatilikEv)
                //{
                //    SatilikEv sev = (SatilikEv)evs[i];
                //    Console.WriteLine(sev.Yazdir());
                //    Console.WriteLine("------------------------------------------------------");
                //}
                //else
                //{
                //    KiralikEv kev = (KiralikEv)evs[i];
                //    Console.WriteLine(kev.Yazdir());
                //    Console.WriteLine("------------------------------------------------------");
                //}
                Console.WriteLine(evs[i].Yazdir());
                Console.WriteLine("------------------------------------------------------");
            }


            //    var computer = new Pc();
            //    computer.ram = 16;
            //    computer.ekrankarti = "rtx4090";
            //    computer.islemci = "i9 14.nesil 3.6Ghz";
            //    computer.anakart = "MSI PRO B650M-B 6800mhz (OC) M.2 AM5 DDR5 mATX Anakart";
            //    computer.ssd = 256;
            //    computer.fiyat = 52000;

            //    Ev evim = new Ev();
            //    evim.alan = 100;
            //    evim.semt = "gazi";
            //    evim.katNo = 2;
            //    evim.odaSayisi = 3;
            //    Console.WriteLine($"Oda Sayisi:{evim.odaSayisi}\nKat No:{evim.katNo}\nAlan:{evim.alan}\nSemt:{evim.semt}");
            //    var evim3 = new Ev();
            //    evim3.alan = 100;

            //    evim3.katNo = 2;
            //    evim3.odaSayisi = 3;
            //    Console.WriteLine(evim.Yazdır());
            //    Console.WriteLine(evim3.Yazdır());

            //    Console.WriteLine($"BELLEKTEKİ TOPLAM EV SAYISI{Ev.sayac}");
            //try
            //{
            //    Ev evim5 = new Ev();
            //    Console.Write("oda sayısı: ");
            //    evim5.OdaSayisi = (int.Parse(Console.ReadLine()));
            //    Console.Write("kat no: ");
            //    evim5.KatNo = (int.Parse(Console.ReadLine()));
            //    Console.Write("Semt: ");
            //    evim5.Semt = (Console.ReadLine());
            //    Console.Write("Alan: ");
            //    evim5.Alan = (double.Parse(Console.ReadLine()));
            //    Console.WriteLine(evim5.Yazdir());
            //    Console.WriteLine(evim5.Buyukluk);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            

            //Ev evim = new Ev();//Ev classındn nesne türetildi
            //evim bir referanstır nesnelerin bellekteki adresini tutarlar
            //Ev =class classlar aynı zamanda bir veri tipidir
            //new: bellekte nesne yaratmaya yarayan anahtar sözcüktür
            //referanslar stackde saklanır
            //nesne: new anahtar sözcüğü ile heap bölgesinde oluşturulurlar


            //erişim belirleyiciler acces modifiers:
            //private:sadece class içerisinde erişilebilir üyelerdir
            //public:class içinde tanımlanan üyeye her yerden erişim sağlar
            //dont repeat yourself

            
        }
        
    }

    class Pc
    {
        public string islemci;
        public string ekrankarti;
        public int ram;
        public int ssd;
        public string anakart;
        public int fiyat;
    }
}
