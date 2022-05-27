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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
            txtID.Text = Odeme.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Odeme.MusteriID.ToString();
                nmTutar.Value = (decimal)Odeme.Tutar;
                dtTarih.Value = Odeme.Tarih;
                cbTur.SelectedItem = Odeme.Tur;
                txtAciklama.Text = Odeme.Aciklama.ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Odeme Odeme { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen tutar giriniz!");
                nmTutar.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmTutar, "");
            }

            if (cbTur.SelectedItem == null)
            {
                errorProvider1.SetError(cbTur, "Ödeme türü seçiniz!");
                cbTur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbTur, "");
            }

            if (txtAciklama.Text == "")
            {
                errorProvider1.SetError(txtAciklama, "Eksik veya hatalı bilgi");
                txtAciklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAciklama, "");
            }
            Odeme.MusteriID = Guid.Parse (txtMusteri.Text);
            Odeme.Tur = cbTur.SelectedItem.ToString();
            Odeme.Tutar = (double)nmTutar.Value;
            Odeme.Aciklama = txtAciklama.Text;
            Odeme.Tarih = dtTarih.Value;



            DialogResult = DialogResult.OK;
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = frm.Musteri.ID.ToString();
            }
        }
    }
}
