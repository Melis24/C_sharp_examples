using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_dik_üçgende_alan_ve_çevre_bulma
{
    class Dik_üçgen
    {
        public int alan;
        public double cevre;
     
        public int alan_hesapla(int kenar1,int kenar2)
        {
             alan = (kenar1 * kenar2) / 2;

            return alan;
        }

        public double cevre_hesapla(int kenar1,int kenar2)
        {
            int c = (kenar1 * kenar1) + (kenar2 * kenar2);
            double kenar3 = Math.Sqrt(c);

            cevre = kenar1 + kenar2 + kenar3;

            return cevre;

        }








    }
}
