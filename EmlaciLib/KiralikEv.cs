using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmlaciLib;

namespace classApp
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }
        public KiralikEv(double kira,double depozito, int katNo, int odaSayisi, string semt, double alan)
        {
            this.Kira = kira;
            this.Depozito = depozito;
            base.KatNo = katNo;
            base.OdaSayisi = odaSayisi;
            base.Semt = semt;
            base.Alan = alan;
        }
        private double kira;
        

        public double Kira
        {
            get
            {
                return kira;
            }
            set
            {
                kira = value;
            }
        }
        private double depozito;

        public double Depozito
        {
            get
            {
                return depozito; 
            }
            set 
            { 
                depozito = value; 
            }
        }
        public override string YazdirEvb()
        {
            return $"{base.Yazdir()}\nKira: {Kira}\nDepozito: {Depozito}";
        }

    }
}   

