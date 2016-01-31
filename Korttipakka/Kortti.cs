using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipakka
{
    class Kortti : IComparable<Kortti>
    {
        private string maa;
        private int arvo;

        public Kortti(string maa, int arvo)
        {
            this.maa = maa;
            this.arvo = arvo;
        }




        public int CompareTo(Kortti other)
        {
            int ret = this.maa.CompareTo(other.maa);
            if (ret == 0)
                return this.arvo - other.arvo;
            else
                return ret;
        }





        public override string ToString()
        {
            string s = maa + " ";

            switch (arvo)
            {
                case 1:
                    s += "1";
                    break;
                case 11:
                    s += "11";
                    break;
                case 12:
                    s += "12";
                    break;
                case 13:
                    s += "13";
                    break;
                default:
                    s += arvo;
                    break;
            }

            return s;
        }


    }
}
    

