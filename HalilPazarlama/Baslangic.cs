using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Baslangic
    {
        public void Doldur(Depo d)
        {
            //CamasirMakinesi cm = new CamasirMakinesi();
            //cm.Marka = "Ariston";
            //cm.Model = "AR123";
            //cm.Kurutma = true;
            //cm.YikamaKapasitesi = 7;
            //cm.Fiyat = 11000;
            //d.Ekle(cm);

            BulasikMakinesi bm = new BulasikMakinesi();
            bm.Marka = "REGAL";
            bm.Model = "KAFA1500";
            bm.ProgramSayisi = 10;
            bm.EnerjiSinifi = "A++";
            bm.Fiyat = 5500;
            d.Ekle(bm);
        }
    }
}
