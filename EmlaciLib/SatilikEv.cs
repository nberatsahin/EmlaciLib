using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlaciLib;

namespace classApp
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }
        public SatilikEv(double satisFiyat, int katNo, int odaSayisi, string semt, double alan) : base(katNo, odaSayisi, semt, alan)
        {
            this.SatisFiyat = satisFiyat;
        }
        public double satisFiyat;

        public double SatisFiyat
        {
            get
            {
                return satisFiyat;
            }
            set
            {
                satisFiyat = value;
            }
        }
        
          public override string YazdirEvb()
        {
            return $"{base.Yazdir()}\nSatış fiyat: {SatisFiyat}";
        }
        //name hiding: türeyen classlarda base classraki üyelerin ismiyle aynı isimle bir üye tanımlanırsa artık türeyen class referansıyla base classtaki üyeye erişilemez.
    }
}
