using System;
using System.Threading;
using System.Transactions;

namespace EmlaciLib
{
    public abstract class Ev
    {
        public Ev(int katNo, int odaSayisi, string semt, double alan)
        {
            this.KatNo = katNo;
            this.OdaSayisi = odaSayisi;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }
        public static int sayac = 0;
        public Ev(int katNo, double alan, int odaSayisi)
        {
            this.OdaSayisi = odaSayisi;

            this.Semt = "kızılay";
            this.Alan = alan;
            sayac++;
        }
        public Ev()
        {
            sayac++;
        }
        public Ev(int odaSayisi, int katNo, double alan, string semt = "kızılay")
        {
            this.OdaSayisi = odaSayisi;

            this.Semt = semt;
            this.Alan = alan;
            //construckter metodlar
            sayac++;
        }

        int odaSayisi;//field
        string semt;
    
        public int KatNo { get; set; }
        //Auto-Propert:Get ve Set BLOKLARINDA İŞLEM YAPILMAYACAĞI ZAMAN KULLANILIR
        //public double Alan { get => alan; set => alan = Math.Abs(value); } //property
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int OdaSayisi{ get => odaSayisi; set => odaSayisi = Math.Abs(value); }

        //FULL PROPERTİES: GET VE SET BLOKLARINDA ÇOK SATIRLI İŞLEMLER YAPMAK İÇİN KULLANILIR

        private double alan;
        
        public string Buyukluk 
        {
            get ;

            private set;
        }
        public double Alan
        {
            get 
            {
                return alan; 
            }
            set 
            {
                if (value < 50)
                {
                    throw new Exception("Minimum alan değeri 50 olmalıdır");

                }
                alan = value;
                if (this.alan > 50 && this.alan <= 75)
                {
                    this.Buyukluk= "kücük ev";
                }
                else if (this.alan > 75 && this.alan <= 120)
                {
                    this.Buyukluk = "ORTA EV";
                }
                else if (this.alan > 120)
                {
                    this.Buyukluk = "BÜYÜK EV";
                }
                
            }
        }

        //public int MyProperty
        //{
        //    get 
        //    { 
        //        //BURADA BAŞKA İŞLEMLER YAPILABİLİR
        //        return myVar; 
        //    }
        //    set 
        //    { 
        //        myVar = value; 
        //        //BURADA FARKLI İŞLEMLER YAPILIR
        //    }
        //}

        #region ödev
        //METODLARLA YAPILAN GETTER VE SETTERLAR
        //public int GetOdaSayisi()=>this.odaSayisi; 

        //public void SetOdaSayisi(int odaSayisi)=>this.odaSayisi = Math.Abs(odaSayisi);

        //public string GetSemt()
        //{
        //    return this.Semt;
        //}
        //public void SetSemt(string semt)
        //{
        //    this.Semt = semt;
        //}
        //public int GetKatNo()
        //{
        //    return this.katNo;
        //}
        //public void SetKatNo(int katNo)
        //{
        //    this.katNo = katNo;
        //}
        //public double GetAlan()
        //{
        //    return this.alan;
        //}
        //public void SetAlan(double alan)
        //{
        //    this.alan = Math.Abs(alan);
        //} 
        #endregion
        public string Yazdir() 
        {

            return $"Oda Sayisi: {OdaSayisi}\nKat No: {KatNo}\nAlan: {Alan}\nSemt: {Semt}\nBüyüklük: {Buyukluk}";

        }
        public abstract string YazdirEvb();

    }
    
    
}
//construckter (yapıcı kurucu metodlar):bir clasdan nesne türetilirken çalışır class içindeki fieldlara varsayılan değer atamalarını yapar
// her class da mutlaka vardır.varsayılan olarak parametre almazlar bu construckterlara default construckter denir
//isimleri class adı ile aynıdır farklı isimde tanımlanamazlar
//geri dönüş tipleri yoktur
//classlardan nesne türetildiğinde çalışan ilk metoddur
//ctor code snipetti ile default construckter oluşturulabilir.ctor+tab
//BİR CLASS İÇİNDE Static olarak tanımlanan üyelere class ismi ile erişilir ve bu üyeler program çalıştığı üece bellekte tutulurlar nesnelerden bağımsız classa ait yapılardır
//Kapsülleme ilkesi (encapsulation): class iinden yapılan işlerin class dışından gizlenmesidir örn. odasyısı fieldına değer atama işlemi yapmak için öncelikle field private yapıldı sonrasında fielda erişebilen publuc SetOdaSayisi(int odasayisi) metodu yazıldı bu metod içinde gelen değerin mutlak değeri alınarakodsaisi değişkenine aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı
//internal yalnızca aynı namespacedeki classlar tarafından erişilebilir
//her classın tek bir base classı olabilir
//virtual anahtar sözcüğü ovveride edilmesi gereken üyeler virtual keywordü ile tanımlanır

//POLYMORPHİSİM base classda virtual olarak tanılanan üyeler türeyen classlarda override edilerek farklı biçimde yazılabilir
