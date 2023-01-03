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
    public partial class uye : Form
    {
        List<kitap> kitaplarim;
        public uye(List<kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void uye_Load(object sender, EventArgs e)
        {
            foreach (kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaYapisi(), kitap.getBasimYili());
            }
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapid = Convert.ToInt32(txt_kitapid.Text);
            kitap hedefKitap = null;
            foreach (kitap Kitap in kitaplarim)
            {
                if (Kitap.getKitapId() == kitapid)
                {
                    hedefKitap = Kitap;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaYapisi(), hedefKitap.getBasimYili());

        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

            foreach (kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaYapisi(), hedefKitap.getBasimYili());
            }
        }
    }
}
