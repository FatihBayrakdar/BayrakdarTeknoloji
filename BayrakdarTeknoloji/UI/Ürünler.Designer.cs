
namespace BayrakdarTeknoloji.UI
{
    partial class Ürünler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnÜrünEkle = new System.Windows.Forms.ToolStripButton();
            this.btnÜrünDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÜrünSil = new System.Windows.Forms.ToolStripButton();
            this.btnÜrünBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(28, 29);
            this.toolStripLabel3.Text = "Ara:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.Size = new System.Drawing.Size(750, 366);
            this.dataGridView3.TabIndex = 7;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÜrünEkle,
            this.btnÜrünDüzenle,
            this.btnÜrünSil,
            this.toolStripSeparator3,
            this.btnÜrünBul,
            this.toolStripTextBox3,
            this.toolStripLabel3});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(750, 32);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnÜrünEkle
            // 
            this.btnÜrünEkle.Image = global::BayrakdarTeknoloji.Properties.Resources.product_add;
            this.btnÜrünEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünEkle.Name = "btnÜrünEkle";
            this.btnÜrünEkle.Size = new System.Drawing.Size(57, 29);
            this.btnÜrünEkle.Text = "Ekle";
            this.btnÜrünEkle.Click += new System.EventHandler(this.btnÜrünEkle_Click);
            // 
            // btnÜrünDüzenle
            // 
            this.btnÜrünDüzenle.Image = global::BayrakdarTeknoloji.Properties.Resources.product_edit;
            this.btnÜrünDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünDüzenle.Name = "btnÜrünDüzenle";
            this.btnÜrünDüzenle.Size = new System.Drawing.Size(78, 29);
            this.btnÜrünDüzenle.Text = "Düzenle";
            this.btnÜrünDüzenle.Click += new System.EventHandler(this.btnÜrünDüzenle_Click);
            // 
            // btnÜrünSil
            // 
            this.btnÜrünSil.Image = global::BayrakdarTeknoloji.Properties.Resources.product_remove;
            this.btnÜrünSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünSil.Name = "btnÜrünSil";
            this.btnÜrünSil.Size = new System.Drawing.Size(48, 29);
            this.btnÜrünSil.Text = "Sil";
            this.btnÜrünSil.Click += new System.EventHandler(this.btnÜrünSil_Click);
            // 
            // btnÜrünBul
            // 
            this.btnÜrünBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnÜrünBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnÜrünBul.Image = global::BayrakdarTeknoloji.Properties.Resources.product_search;
            this.btnÜrünBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÜrünBul.Name = "btnÜrünBul";
            this.btnÜrünBul.Size = new System.Drawing.Size(29, 29);
            this.btnÜrünBul.Text = "Bul";
            this.btnÜrünBul.Click += new System.EventHandler(this.btnÜrünBul_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(200, 32);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancel);
            this.tabPage3.Controls.Add(this.btnOk);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.toolStrip2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ÜRÜNLER";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(673, 407);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(578, 407);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 464);
            this.tabControl1.TabIndex = 2;
            // 
            // Ürünler
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(764, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Ürünler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Ürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnÜrünBul;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnÜrünSil;
        private System.Windows.Forms.ToolStripButton btnÜrünDüzenle;
        private System.Windows.Forms.ToolStripButton btnÜrünEkle;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}