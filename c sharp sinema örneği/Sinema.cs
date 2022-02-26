using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_sinema_örneği
{
    class Sinema
    {

        public int toplamkoltuksayısı;
        public int boskoltuksayısı;
        public double bakiye;
        public int salonNo;

        const double tam = 15.0;
        const double Indirimli = 10.0;


        public Sinema(int salonn,int koltuksayısı)
        {
            toplamkoltuksayısı = koltuksayısı;
            salonNo = salonn;
            boskoltuksayısı = koltuksayısı;
            bakiye = 0;
        }

        public void biletsat(bool indirimli)
        {
            boskoltuksayısı--;
            if(indirimli)
            {
                bakiye += Indirimli;
            }
            else
            {
                bakiye += tam;
            }
        }

        public void biletiptal(bool indirimli)
        {
            boskoltuksayısı++;

            if(indirimli)
            {
                bakiye -= Indirimli;
            }
            else
            {
                bakiye -= tam;
            }

        }

        public int boskoltukogren()
        {
            return boskoltuksayısı;
        }

        public double bakiyeogren()
        {
            return bakiye;
        }

    }
}
