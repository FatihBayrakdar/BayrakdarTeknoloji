using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayrakdarTeknoloji.UI
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        public Satis Satis { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen fiyat giriniz!");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;
            Satis.UrunID = Guid.Parse (txtMusteri.Text);
            Satis.MusteriID = Guid.Parse (txtUrun.Text);
            

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtUrun.Text = Satis.UrunID.ToString();
                nmFiyat.Value = (decimal)Satis.Fiyat;
                dtTarih.Value = Satis.Tarih;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ürünler frm = new Ürünler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUrun.Text = frm.Urun.ID.ToString();
            }
        }
    }
}
