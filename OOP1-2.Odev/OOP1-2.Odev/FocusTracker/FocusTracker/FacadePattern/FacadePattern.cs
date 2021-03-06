using System;
using System.Collections.Generic;
using System.Text;

namespace FocusTracker.Facade
{
    //Facade Class
    public class FacadePattern
    {
        private Kutuphane _kutuphane;
        private KutuphaneYonetimi _kutuphaneYonetimi;
        private Kota _kota;

        public FacadePattern()
        {
            _kutuphane = new Kutuphane();
            _kutuphaneYonetimi = new KutuphaneYonetimi();
            _kota = new Kota();

        }

        public void KıtapOduncAl(Uye u, decimal talep)
        {
            if (!_kutuphaneYonetimi.BorcKontrol(u.ogrNo) && _kota.KitapOduncAlmaDurumu(u))
            {
                _kutuphane.KıtapOduncAl(u, talep);
                Console.WriteLine("Kitap ödünç aldık…");
            }

        }
    }
}
