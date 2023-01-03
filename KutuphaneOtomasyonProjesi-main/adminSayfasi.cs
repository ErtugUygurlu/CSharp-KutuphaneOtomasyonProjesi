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
    public partial class adminSayfasi : Form
    {
        List<kisi> kisilerim;
        List<kitap> kitaplarim;

        public adminSayfasi(List<kisi> kisilerim, List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void adminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (kisi Kisi in kisilerim)
            {
                dataGridView1.Rows.Add(Kisi.getId(), Kisi.getIsim(), Kisi.getSoyisim(), Kisi.getOlusturmaTarih(), Kisi.getKullaniciAdi(), Kisi.getSifre(), Kisi.getYetki());
            }
            foreach (kitap Kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(Kitap.getKitapId(), Kitap.getKitapIsim(), Kitap.getKitapYazar(), Kitap.getKitapDili(), Kitap.getYayinEvi(), Kitap.getTur(), Kitap.getAdet(), Kitap.getSayfaYapisi(), Kitap.getBasimYili());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txt_id.Text), txt_isim.Text, txt_soyisim.Text, maskedTextBox1.Text, txt_kullaniciadi.Text, txt_sifre.Text, txt_yetki.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
        }


        public void textleridoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tarih = maskedTextBox1.Text;
            string kullaniciadi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, soyisim, tarih, kullaniciadi, sifre, yetki);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxuyeislem.Controls.Count; i++)
            {
                if (groupBoxuyeislem.Controls[i] is TextBox || groupBoxuyeislem.Controls[i] is MaskedTextBox)
                {
                    groupBoxuyeislem.Controls[i].Text = string.Empty;
                }
            }
        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text, txt_kitapisimm.Text, txt_kitapyazarr.Text, txt_dill.Text, txt_yayinevii.Text, txt_turr.Text, txt_adett.Text, txt_sayfaa.Text, txt_basimyilii.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapgüncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapismi = txt_kitapisimm.Text;
            string kitapyazar = txt_kitapyazarr.Text;
            string kitapdili = txt_dill.Text;
            string yayinevi = txt_yayinevii.Text;
            string tur = txt_turr.Text;
            string adet = txt_adett.Text;
            string sayfa = txt_sayfaa.Text;
            string basimyili = txt_basimyilii.Text;
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapismi, kitapyazar, kitapdili, yayinevi, tur, adet, sayfa, basimyili);
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxkitap.Controls.Count; i++)
            {
                if (groupBoxkitap.Controls[i] is TextBox)
                {
                    groupBoxkitap.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisimm.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazarr.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dill.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevii.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_turr.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adett.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfaa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyilii.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            kisi hedefkisi = null;
            int secilenkisiID = Convert.ToInt32(textBox1.Text);

            foreach (kisi Kisi in kisilerim)
            {
                if (Kisi.getId() == secilenkisiID)
                {
                    hedefkisi = Kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmaTarih(), hedefkisi.getKullaniciAdi(), hedefkisi.getYetki());
        }


        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            foreach (kisi hedefkisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefkisi.getId(), hedefkisi.getIsim(), hedefkisi.getSoyisim(), hedefkisi.getOlusturmaTarih(), hedefkisi.getKullaniciAdi(), hedefkisi.getYetki());
            }
        }


        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            kitap hedefkitap = null;
            int kitapID = Convert.ToInt32(textBox2.Text);

            foreach (kitap Kitap in kitaplarim)
            {
                if (Kitap.getKitapId() == kitapID)
                {
                    hedefkitap = Kitap;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getKitapIsim(), hedefkitap.getKitapYazar(), hedefkitap.getKitapDili(), hedefkitap.getYayinEvi(), hedefkitap.getTur(), hedefkitap.getAdet(), hedefkitap.getSayfaYapisi(), hedefkitap.getBasimYili());
        }


        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            foreach (kitap hedefkitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefkitap.getKitapId(), hedefkitap.getKitapIsim(), hedefkitap.getKitapYazar(), hedefkitap.getKitapDili(), hedefkitap.getYayinEvi(), hedefkitap.getTur(), hedefkitap.getAdet(), hedefkitap.getSayfaYapisi(), hedefkitap.getBasimYili());
            }
        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
