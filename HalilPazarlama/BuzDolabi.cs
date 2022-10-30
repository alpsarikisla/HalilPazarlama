using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class BuzDolabi
    {
        public string Marka;
        public string Model;
        public double Fiyat;
        public int IcHacim;
        public int KapiSayisi;
        public bool BuzMakinasi;

        public string Yazdir()
        {
            return $"Marka={Marka} Model={Model}\nKapi Sayisi={KapiSayisi} Buz Makinası={BuzMakinasi}\nFiyat={Fiyat}";
        }
    }
}
