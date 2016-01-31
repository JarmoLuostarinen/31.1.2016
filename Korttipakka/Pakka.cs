using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipakka
{
    class Pakka
    {
        public List<Kortti> Lista { get; set; }

        public Pakka()
        {

        }

        public void Sort()
        {
            Lista.Sort();
        }



        public void LuoPakka()
        {
            Lista = new List<Kortti>();
            string[] maat = { "Hertta", "Ruutu", "Risti", "Pata" };

            for (int j = 0; j < maat.Length; j++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Lista.Add(new Kortti(maat[j], i));
                }
            }
        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Kortti k in Lista)
            {
                sb.Append(k.ToString());
                sb.Append("\n");
            }

            return sb.ToString();
        }


        public void Shuffle()
        {
            Random rng = new Random();
            int n = Lista.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Kortti value = Lista[k];
                Lista[k] = Lista[n];
                Lista[n] = value;
            }
        }

        /// <summary>
        /// Jakaa käden pelaajalle
        /// </summary>
        /// <param name="pakka">Jäljellä oleva korttipakka</param>
        /// <param name="n">jaettavien kortien lukumäärä</param>
        /// <returns>käsi</returns>
        /// 
        public List<Kortti> DealHand(int n)
        {
            List<Kortti> kasi = Lista.GetRange(Lista.Count - n, n);
            Lista.RemoveRange(Lista.Count - n, n);
            return kasi;
        }

    }
}

    

