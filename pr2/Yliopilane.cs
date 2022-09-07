using System;
using System.Collections.Generic;
using System.Text;

namespace pr2
{
    class Yliopilane : Isik
    {
        public int kursus { get; set; }
        public double stip { get; set; }
        protected string oppeasutus;
        protected string eriala;

        public Yliopilane(string sugu = "---", string nimi = "---", int synniAasta = 0,
      int kursus=0, double stip=0, string oppeasutus="Oxford", string eriala="IT")
            :base(sugu, nimi, synniAasta)
        { this.kursus = kursus;this.stip = stip;
            this.oppeasutus = oppeasutus; this.eriala = eriala; }

        public Yliopilane(Yliopilane ob)
        : base(ob)
        {
            this.kursus = ob.kursus; this.stip = ob.stip;
            this.oppeasutus = ob.oppeasutus; this.eriala = ob.eriala;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine("  {0} {1,7:f2} {2,-15} {3,-" +
                "15}",
                kursus, stip, oppeasutus, eriala);
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            return stip; // eeldame et stip on maksuvaba
        }

    }
}
