using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryV1
{
    // Nesnelerin üretiminden sorumlu olan(Client kullanacak) bu kısım şuan Open-Close'a ters. Başka bir ödeme tipi devreye girerse ve ödeme yaparken ek başka bir parametre kullanırsa sıkıntı. Aynı zamanda nesne hem üretiliyor hem de kullanılıyor(Single Responsibility'e ters). Factory pattern sadece bu üretimle ilgilenecek. Ve odeme helper'la kullanılacak ya da direkt client çağıracak. 
    class OdemeHelper
    {
        public string Ode(decimal tutar, OdemeTipleri odemeTipi)
        {
            string sonuc = "";
            switch (odemeTipi)
            {
                case OdemeTipleri.KrediKarti:
                    KrediKartıOdeme krediKartıOdeme = new();
                    sonuc = krediKartıOdeme.OdemeYap(tutar);
                    break;
                case OdemeTipleri.Havale:
                    HavaleOdeme havaleOdeme = new();
                    sonuc = havaleOdeme.OdemeYap(tutar);
                    break;
                default:
                    sonuc = "Hatalı Odeme tipi";
                    break;
            }
            return sonuc;
        }
    }

    enum OdemeTipleri
    {
        KrediKarti = 1,
        Havale = 2
    }
}
