using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class BulasikMakinesi
    {
        public string Marka;
        public string Model;
        public double Fiyat;
        public int ProgramSayisi;
        public string EnerjiSinifi;

        public string Yazdir()
        {
            return $"Marka={Marka} Model={Model}\nProgram Sayisi={ProgramSayisi} Enerji Sınıfı={EnerjiSinifi}\nFiyat={Fiyat}";
        }
    }
}
