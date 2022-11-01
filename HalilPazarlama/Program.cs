using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();

            #region Doldur

            CamasirMakinesi cm = new CamasirMakinesi("Ariston", "AR123", 11000, 7, true);
            d.Ekle(cm);
            d.Ekle(new CamasirMakinesi("SIEMENS", "S123", 5000, 8, true));

            BulasikMakinesi bm = new BulasikMakinesi();
            bm.Marka = "REGAL";
            bm.Model = "KAFA1500";
            bm.ProgramSayisi = 10;
            bm.EnerjiSinifi = "A++";
            bm.Fiyat = 5500;
            d.Ekle(bm);

            #endregion

            d.Listele();
        }
    }
}
