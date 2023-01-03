using kutuphaneOtamasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtamasyonu
{
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        List<kitap> kitaplarim = new List<kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";
            kullaniciAdi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;
            bool kontrol = false;

            foreach (kisi Kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == Kisi.getKullaniciAdi() && sifre.ToLower() == Kisi.getSifre() && Kisi.getYetki() == "admin")
                {
                    adminSayfasi adminSayfasii = new adminSayfasi(kisilerim, kitaplarim);
                    adminSayfasii.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kullaniciAdi.ToLower() == Kisi.getKullaniciAdi() && sifre.ToLower() == Kisi.getSifre() && Kisi.getYetki() == "üye")
                {
                    uye uyeSayfasi = new uye(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }

            if (!kontrol)
            {
                MessageBox.Show("Hatalı giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1, "Ertuğ", "Uygurlu", DateTime.Now, "ertuğ", "1", "admin"));
            kisilerim.Add(new kisi(2, "Yusuf", "Erbaş", DateTime.Now, "yusuf", "2", "üye"));
            kisilerim.Add(new kisi(3, "Merve", "Kaya", DateTime.Now, "merve", "3", "üye"));
            kisilerim.Add(new kisi(4, "Tuğba", "Sarı", DateTime.Now, "tuğba", "4", "üye"));
            kitaplarim.Add(new kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 350, 760, 2015));
            kitaplarim.Add(new kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Can Çocuk Yayınları", "Roman", 100, 350, 2010));
            kitaplarim.Add(new kitap(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can Çocuk Yayınları", "Roman", 50, 60, 2018));
            kitaplarim.Add(new kitap(5, "Kürk Mantolu Madonna", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 50, 220, 2015));

        }
    }
}
