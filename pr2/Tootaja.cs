using System;
using System.Collections.Generic;
using System.Text;

namespace pr2
{
    class Tootaja : Isik
    {
        protected string asutus;
        protected string amet;
        protected double tootasu;   // eestis peetakse silmas brutopalka
        public Tootaja(string nimi, string sugu)
        {
            this.nimi = nimi;
            this.sugu = sugu;
        }
        public Tootaja(string sugu = "---", string nimi = "---", int synniAasta = 0,
           string asutus="---", string amet="---", double tootasu=0)
            :base(sugu,nimi,synniAasta)
        { this.asutus = asutus; this.amet = amet; this.tootasu = tootasu;  }

        public Tootaja(Tootaja ob)
        : base(ob)
       { this.asutus = ob.asutus; this.amet = ob.amet; this.tootasu = ob.tootasu; }

        public override void print()
        {
            base.print();
            Console.WriteLine("  {0,-15} {1,-15} {2,7:f2}",
                asutus, amet, tootasu,base.arvutaVanus());
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
           double sedaTeEiNae =(tootasu - maksuvaba) * (tulumaks / 100);
           double netopalk = tootasu - sedaTeEiNae;
            return netopalk;
        }


    }
}
