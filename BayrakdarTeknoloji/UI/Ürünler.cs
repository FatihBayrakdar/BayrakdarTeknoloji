using BayrakdarTeknoloji.BL;
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
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }
        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun()
            {
                Text = "Ürün Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },

            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunEkle(frm.Urun);
                if (b)
                {

                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }

        private void btnÜrünBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(toolStripTextBox3.Text);
            if (ds != null)
                dataGridView3.DataSource = ds.Tables[0];
        }

        private void btnÜrünDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            FrmUrun frm = new FrmUrun()
            {
                Text = "Ürün Güncelle",
                Güncelleme = true,
                Urun = new Urun()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Kategori = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse (row.Cells[3].Value.ToString()),
                    Stok = double.Parse (row.Cells[4].Value.ToString()),
                    Birim = row.Cells[5].Value.ToString(),
                    Detay = row.Cells[6].Value.ToString(),
                },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunGüncelle(frm.Urun);
                if (b)
                {
                    row.Cells[1].Value = frm.Urun.Ad;
                    row.Cells[2].Value = frm.Urun.Kategori;
                    row.Cells[3].Value = frm.Urun.Fiyat;
                    row.Cells[4].Value = frm.Urun.Stok;
                    row.Cells[5].Value = frm.Urun.Birim;
                    row.Cells[6].Value = frm.Urun.Detay;
                }

            };
        }

        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin Mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }

            };
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.UrunGetir("");
            if (ds2 != null)
                dataGridView3.DataSource = ds2.Tables[0];
        }

        public Urun Urun { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
                        DataGridViewRow row = dataGridView3.SelectedRows[0];

            Urun = new Urun()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Ad = row.Cells[1].Value.ToString(),
                Kategori = row.Cells[2].Value.ToString(),
                Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                Stok = double.Parse(row.Cells[4].Value.ToString()),
                Birim = row.Cells[5].Value.ToString(),
                Detay = row.Cells[6].Value.ToString(),
            };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnÜrünEkle_Click_1(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun()
            {
                Text = "Ürün Ekle",
                Urun = new Urun() { ID = Guid.NewGuid() },
            };
        }
    }
}
