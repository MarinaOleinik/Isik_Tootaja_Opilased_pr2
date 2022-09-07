using System;
using System.Collections.Generic;
using System.Text;

namespace pr2
{
    class GymnaasiumiOpilane : Isik
    {
        protected string koolinimi;
        protected int klass; // 10 klass jne
        protected string spetsialiseerumine;

        public GymnaasiumiOpilane(string sugu = "---", string nimi = "---",
            int synniAasta = 0, string koolinimi="---", int klass=0,
            string spetsialiseerumine="---")
            :base(sugu,nimi,synniAasta)
        { this.koolinimi = koolinimi; this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine; }

        public GymnaasiumiOpilane(GymnaasiumiOpilane ob)
           : base(ob)
        {
            this.koolinimi = ob.koolinimi; this.klass = ob.klass;
            this.spetsialiseerumine = ob.spetsialiseerumine;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(" {0,-15} {1,2} {2,-15}",
                koolinimi,klass,spetsialiseerumine);
        }

        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            return 0;
        }

    }
}
