using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama
{
    public class Depo
    {
        CamasirMakinesi[] CamasirMakineleri;
        BulasikMakinesi[] BulasikMakineleri;
        BuzDolabi[] Buzdolaplari;

        public Depo()
        {
            CamasirMakineleri = new CamasirMakinesi[0];
            BulasikMakineleri = new BulasikMakinesi[0];
            Buzdolaplari = new BuzDolabi[0];
        }

        public void Ekle(CamasirMakinesi cm)
        {
            CamasirMakinesi[] gecici = new CamasirMakinesi[CamasirMakineleri.Length + 1];
            Array.Copy(CamasirMakineleri, gecici, CamasirMakineleri.Length);
            gecici[gecici.Length - 1] = cm;
            CamasirMakineleri = gecici;
        }
        public void Ekle(BulasikMakinesi bm)
        {
            BulasikMakinesi[] gecici = new BulasikMakinesi[BulasikMakineleri.Length + 1];
            Array.Copy(BulasikMakineleri, gecici, BulasikMakineleri.Length);
            gecici[gecici.Length - 1] = bm;
            BulasikMakineleri = gecici;
        }
        public void Ekle(BuzDolabi bd)
        {
            BuzDolabi[] gecici = new BuzDolabi[Buzdolaplari.Length + 1];
            Array.Copy(Buzdolaplari, gecici, Buzdolaplari.Length);
            gecici[gecici.Length - 1] = bd;
            Buzdolaplari = gecici;
        }

        public void Listele()
        {
            Console.WriteLine("Çamaşır Makineleri");
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine($"---Ürün No=100{i+1}---");
                Console.WriteLine(CamasirMakineleri[i].Yazdir());
            }
            Console.WriteLine("Bulaşık Makineleri");
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine($"---Ürün No=200{i + 1}---");
                Console.WriteLine(BulasikMakineleri[i].Yazdir());
            }
            Console.WriteLine("Buz dolapları Makineleri");
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                Console.WriteLine($"---Ürün No=300{i + 1}---");
                Console.WriteLine(Buzdolaplari[i].Yazdir());
            }
        }
    }
}
