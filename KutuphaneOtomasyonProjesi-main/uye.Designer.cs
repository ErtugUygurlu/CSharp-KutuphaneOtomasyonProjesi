namespace kutuphaneOtamasyonu
{
    partial class uye
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
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(12, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(199, 12);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(93, 14);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapid.TabIndex = 1;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(12, 359);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 23);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfasayisi,
            this.basimyili});
            this.dataGridView2.Location = new System.Drawing.Point(12, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(788, 268);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAPID";
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 85;
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "KİTAP İSİM";
            this.kitapisim.Name = "kitapisim";
            this.kitapisim.Width = 85;
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "KİTAP YAZAR";
            this.kitapyazar.Name = "kitapyazar";
            this.kitapyazar.Width = 85;
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "KİTAP DİLİ";
            this.kitapdili.Name = "kitapdili";
            this.kitapdili.Width = 85;
            // 
            // yayinevi
            // 
            this.yayinevi.HeaderText = "YAYIN EVİ";
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Width = 85;
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.Name = "tur";
            this.tur.Width = 85;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            this.adet.Width = 85;
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.HeaderText = "SAYFA";
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Width = 85;
            // 
            // basimyili
            // 
            this.basimyili.HeaderText = "BASIM YILI";
            this.basimyili.Name = "basimyili";
            this.basimyili.Width = 85;
            // 
            // uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 394);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_kitapid);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_ara);
            this.Name = "uye";
            this.Text = "uye";
            this.Load += new System.EventHandler(this.uye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
    }
}