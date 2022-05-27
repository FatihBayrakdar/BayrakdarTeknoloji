
namespace BayrakdarTeknoloji
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMüşteriler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnÜrünler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatışYap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnÖdemeYap = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnÖdemeDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÖdemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSatışDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnSatışSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSatışAra = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMüşteriler,
            this.toolStripSeparator1,
            this.btnÜrünler,
            this.toolStripSeparator2,
            this.btnSatışYap,
            this.toolStripSeparator3,
            this.btnÖdemeYap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1015, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMüşteriler
            // 
            this.btnMüşteriler.Image = global::BayrakdarTeknoloji.Properties.Resources.people_customer_man;
            this.btnMüşteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMüşteriler.Name = "btnMüşteriler";
            this.btnMüşteriler.Size = new System.Drawing.Size(96, 36);
            this.btnMüşteriler.Text = "Müşteriler";
            this.btnMüşteriler.Click += new System.EventHandler(this.btnMüşteriler_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnÜrünler
            // 
            this.btnÜrünler.Image = global::BayrakdarTeknoloji.Properties.Resources.products;
            this.btnÜrünler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünler.Name = "btnÜrünler";
            this.btnÜrünler.Size = new System.Drawing.Size(82, 36);
            this.btnÜrünler.Text = "Ürünler";
            this.btnÜrünler.Click += new System.EventHandler(this.btnÜrünler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Image = global::BayrakdarTeknoloji.Properties.Resources.shop;
            this.btnSatışYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(89, 36);
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnÖdemeYap
            // 
            this.btnÖdemeYap.Image = global::BayrakdarTeknoloji.Properties.Resources.money;
            this.btnÖdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeYap.Name = "btnÖdemeYap";
            this.btnÖdemeYap.Size = new System.Drawing.Size(104, 36);
            this.btnÖdemeYap.Text = "Ödeme Yap";
            this.btnÖdemeYap.Click += new System.EventHandler(this.btnÖdemeYap_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödemeler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 35);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(791, 361);
            this.dataGridView2.TabIndex = 5;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÖdemeDüzenle,
            this.btnÖdemeSil,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(791, 32);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnÖdemeDüzenle
            // 
            this.btnÖdemeDüzenle.Image = global::BayrakdarTeknoloji.Properties.Resources.money_edit;
            this.btnÖdemeDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeDüzenle.Name = "btnÖdemeDüzenle";
            this.btnÖdemeDüzenle.Size = new System.Drawing.Size(78, 29);
            this.btnÖdemeDüzenle.Text = "Düzenle";
            this.btnÖdemeDüzenle.Click += new System.EventHandler(this.btnÖdemeDüzenle_Click);
            // 
            // btnÖdemeSil
            // 
            this.btnÖdemeSil.Image = global::BayrakdarTeknoloji.Properties.Resources.money_remove;
            this.btnÖdemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÖdemeSil.Name = "btnÖdemeSil";
            this.btnÖdemeSil.Size = new System.Drawing.Size(48, 29);
            this.btnÖdemeSil.Text = "Sil";
            this.btnÖdemeSil.Click += new System.EventHandler(this.btnÖdemeSil_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton3.Text = "Bul";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 32);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(28, 29);
            this.toolStripLabel2.Text = "Ara:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Satışlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSatışDüzenle,
            this.btnSatışSil,
            this.toolStripSeparator4,
            this.btnSatışAra,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1001, 32);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSatışDüzenle
            // 
            this.btnSatışDüzenle.Image = global::BayrakdarTeknoloji.Properties.Resources.shop_edit;
            this.btnSatışDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışDüzenle.Name = "btnSatışDüzenle";
            this.btnSatışDüzenle.Size = new System.Drawing.Size(78, 29);
            this.btnSatışDüzenle.Text = "Düzenle";
            this.btnSatışDüzenle.Click += new System.EventHandler(this.btnSatışDüzenle_Click);
            // 
            // btnSatışSil
            // 
            this.btnSatışSil.Image = global::BayrakdarTeknoloji.Properties.Resources.shop_remove;
            this.btnSatışSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışSil.Name = "btnSatışSil";
            this.btnSatışSil.Size = new System.Drawing.Size(48, 29);
            this.btnSatışSil.Text = "Sil";
            this.btnSatışSil.Click += new System.EventHandler(this.btnSatışSil_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // btnSatışAra
            // 
            this.btnSatışAra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSatışAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSatışAra.Image = global::BayrakdarTeknoloji.Properties.Resources.shop_search;
            this.btnSatışAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSatışAra.Name = "btnSatışAra";
            this.btnSatışAra.Size = new System.Drawing.Size(29, 29);
            this.btnSatışAra.Text = "Bul";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 32);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 29);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 492);
            this.tabControl1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 428);
            this.dataGridView1.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AnaForm";
            this.Text = "BAYRAKDAR TEKNOLOJİ";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMüşteriler;
        private System.Windows.Forms.ToolStripButton btnÜrünler;
        private System.Windows.Forms.ToolStripButton btnSatışYap;
        private System.Windows.Forms.ToolStripButton btnÖdemeYap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnÖdemeDüzenle;
        private System.Windows.Forms.ToolStripButton btnÖdemeSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnSatışDüzenle;
        private System.Windows.Forms.ToolStripButton btnSatışSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSatışAra;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

