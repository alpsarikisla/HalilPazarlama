using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class CamasirMakinesi
    {
        public string Marka;
        public string Model;
        public double Fiyat;
        public int YikamaKapasitesi;
        public bool Kurutma;

        public CamasirMakinesi(string marka, string model, double fiyat, int yikamaKapasitesi, bool kurutma)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            YikamaKapasitesi = yikamaKapasitesi;
            Kurutma = kurutma;
        }

        public string Yazdir()
        {
            //return "Selam";
            return $"Marka={Marka} Model={Model}\nYıkama Kapasitesi={YikamaKapasitesi} Kurutma={Kurutma}\nFiyat={Fiyat}";
        }
    }
}
