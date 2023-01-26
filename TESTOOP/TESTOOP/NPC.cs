using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTOOP
{
    class NPC:HerniPostava
    {

       public bool sila=false;
        public int prace = 0;
        enum Prace
        {
            obchodník,
            nepřítel,
            obyvatel
        }
        public NPC(string jmeno, int prace, bool sila):base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }
        public NPC(string jmeno, int prace) : base(jmeno)
        {
            sila = false;
        }

        public override sealed void ZmenaPozice()
        {
            poziceX = 50;
            poziceY = 50;
        }
        public override string ToString()
        {
            string pracevypis;
            if (prace == 0) pracevypis = Prace.obchodník.ToString();
            else if (prace == 1) pracevypis = Prace.nepřítel.ToString();
            else pracevypis = Prace.obyvatel.ToString();
            if(sila) return base.ToString() + string.Format(", práce: {0} a je boss",pracevypis);
            else return base.ToString() + string.Format(" práce: {0} a není boss", pracevypis);
        }
    }
}
