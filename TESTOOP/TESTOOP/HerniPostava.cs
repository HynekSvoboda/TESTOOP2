using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTOOP
{
    class HerniPostava
    {
        protected string jmeno;
       protected int poziceX=0;
       protected int poziceY=0;
       protected int level = 1;
        int PoziceX
        {
            get
            {
               return poziceX;
            }
        }
        int PoziceY
        {
            get
            {
                return poziceY;
            }
        }
        string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.Length > 10)MessageBox.Show("Příliš dlouhé jméno!");
                else jmeno = value;
            }
        }

        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
        }
        public virtual void ZmenaPozice()
        {
            poziceX += 10;
            poziceY += 10;
        }
        public override string ToString()
        {
            return string.Format("{0}, level {1}, pozice X {2}, pozice Y: {3} ,", Jmeno, level, PoziceX, PoziceY);
        }

    }
}
