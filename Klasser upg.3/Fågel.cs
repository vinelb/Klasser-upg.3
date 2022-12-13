using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_upg._3
{
    public class Fågel
    {
        private int Vikt = 0;
        private int Längd = 0;
        private string Namn = "okänd";

        public int getVikt()
        {
            return this.Vikt;
        }
        public int getLängd()
        {
            return this.Längd;
        }
        public string getNamn()
        {
            return this.Namn;
        }
        public void setLängd(int längd)
        {
            this.Längd = längd;
        }
        public void setVikt(int vikt)
        {
            this.Vikt = vikt;
        }
        public void setNamn(string namn)
        {
            this.Namn = namn;
        }
    }
}
