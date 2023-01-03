using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphaneOtamasyonu.Model
{
    public class kitap
    {
        public int kitapid { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayinEvi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYili { get; set; }


        public kitap(int kitapid, string kitapIsim, string kitapYazar, string kitapDili, string yayinEvi, string tur, int adet, int sayfaSayisi, int basimYili)
        {
            this.kitapid = kitapid;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayinEvi = yayinEvi;
            this.tur = tur;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYili = basimYili;
        }

        public int getKitapId()
        {
            return this.kitapid;
        }
        public string getKitapIsim()
        {
            return this.kitapIsim;
        }
        public string getKitapYazar()
        {
            return this.kitapYazar;
        }
        public string getKitapDili()
        {
            return this.kitapDili;
        }
        public string getYayinEvi()
        {
            return this.yayinEvi;
        }
        public string getTur()
        {
            return this.tur;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public int getSayfaYapisi()
        {
            return this.sayfaSayisi;
        }
        public int getBasimYili()
        {
            return this.basimYili;
        }
    }

}
