namespace ProjeRestaurant
{
	partial class FrmSiparisEkran
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisEkran));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listViewKategori = new System.Windows.Forms.ListView();
			this.ımageListKategori = new System.Windows.Forms.ImageList(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listViewUrunler = new System.Windows.Forms.ListView();
			this.ımageListÜrünler = new System.Windows.Forms.ImageList(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnMasaIptal = new System.Windows.Forms.Button();
			this.btnSiparisOlustur = new System.Windows.Forms.Button();
			this.radioNakit = new System.Windows.Forms.RadioButton();
			this.radioKrediKart = new System.Windows.Forms.RadioButton();
			this.labelSecilenFiyat = new System.Windows.Forms.Label();
			this.LblOdenmesiGereken = new System.Windows.Forms.Label();
			this.dataGridSecilen = new System.Windows.Forms.DataGridView();
			this.dataGridViewSiparis = new System.Windows.Forms.DataGridView();
			this.labelMasaNo = new System.Windows.Forms.Label();
			this.btnOdeme = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSecilen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.listViewKategori);
			this.groupBox1.Location = new System.Drawing.Point(12, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(587, 163);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kategoriler";
			// 
			// listViewKategori
			// 
			this.listViewKategori.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewKategori.HideSelection = false;
			this.listViewKategori.LargeImageList = this.ımageListKategori;
			this.listViewKategori.Location = new System.Drawing.Point(3, 16);
			this.listViewKategori.Name = "listViewKategori";
			this.listViewKategori.Size = new System.Drawing.Size(581, 144);
			this.listViewKategori.TabIndex = 3;
			this.listViewKategori.UseCompatibleStateImageBehavior = false;
			this.listViewKategori.Click += new System.EventHandler(this.listViewKategori_Click);
			// 
			// ımageListKategori
			// 
			this.ımageListKategori.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKategori.ImageStream")));
			this.ımageListKategori.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageListKategori.Images.SetKeyName(0, "category.png");
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.listViewUrunler);
			this.groupBox2.Location = new System.Drawing.Point(12, 181);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(587, 319);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ürünler";
			// 
			// listViewUrunler
			// 
			this.listViewUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewUrunler.HideSelection = false;
			this.listViewUrunler.LargeImageList = this.ımageListÜrünler;
			this.listViewUrunler.Location = new System.Drawing.Point(3, 16);
			this.listViewUrunler.Name = "listViewUrunler";
			this.listViewUrunler.Size = new System.Drawing.Size(581, 300);
			this.listViewUrunler.TabIndex = 4;
			this.listViewUrunler.UseCompatibleStateImageBehavior = false;
			this.listViewUrunler.DoubleClick += new System.EventHandler(this.listViewUrunler_DoubleClick);
			// 
			// ımageListÜrünler
			// 
			this.ımageListÜrünler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListÜrünler.ImageStream")));
			this.ımageListÜrünler.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageListÜrünler.Images.SetKeyName(0, "corba.jpg");
			this.ımageListÜrünler.Images.SetKeyName(1, "icecek.jpg");
			this.ımageListÜrünler.Images.SetKeyName(2, "kahvalti.jpg");
			this.ımageListÜrünler.Images.SetKeyName(3, "makarna.jpg");
			this.ımageListÜrünler.Images.SetKeyName(4, "salata.jpg");
			this.ımageListÜrünler.Images.SetKeyName(5, "tatli.jpg");
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Controls.Add(this.btnMasaIptal);
			this.groupBox3.Controls.Add(this.btnSiparisOlustur);
			this.groupBox3.Controls.Add(this.radioNakit);
			this.groupBox3.Controls.Add(this.radioKrediKart);
			this.groupBox3.Controls.Add(this.labelSecilenFiyat);
			this.groupBox3.Controls.Add(this.LblOdenmesiGereken);
			this.groupBox3.Controls.Add(this.btnOdeme);
			this.groupBox3.Controls.Add(this.dataGridSecilen);
			this.groupBox3.Controls.Add(this.dataGridViewSiparis);
			this.groupBox3.Location = new System.Drawing.Point(605, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(311, 488);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Siparişler";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(208, 171);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 32);
			this.button1.TabIndex = 15;
			this.button1.Text = "Hepsini Aktar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnMasaIptal
			// 
			this.btnMasaIptal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMasaIptal.BackColor = System.Drawing.Color.Tomato;
			this.btnMasaIptal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnMasaIptal.FlatAppearance.BorderSize = 2;
			this.btnMasaIptal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnMasaIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMasaIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMasaIptal.Location = new System.Drawing.Point(113, 171);
			this.btnMasaIptal.Name = "btnMasaIptal";
			this.btnMasaIptal.Size = new System.Drawing.Size(89, 32);
			this.btnMasaIptal.TabIndex = 14;
			this.btnMasaIptal.Text = "Masa İptal";
			this.btnMasaIptal.UseVisualStyleBackColor = false;
			this.btnMasaIptal.Click += new System.EventHandler(this.btnMasaIptal_Click);
			// 
			// btnSiparisOlustur
			// 
			this.btnSiparisOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSiparisOlustur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSiparisOlustur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSiparisOlustur.Location = new System.Drawing.Point(3, 171);
			this.btnSiparisOlustur.Name = "btnSiparisOlustur";
			this.btnSiparisOlustur.Size = new System.Drawing.Size(104, 32);
			this.btnSiparisOlustur.TabIndex = 13;
			this.btnSiparisOlustur.Text = "Sipariş Onayla";
			this.btnSiparisOlustur.UseVisualStyleBackColor = true;
			this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
			// 
			// radioNakit
			// 
			this.radioNakit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.radioNakit.AutoSize = true;
			this.radioNakit.Location = new System.Drawing.Point(220, 424);
			this.radioNakit.Name = "radioNakit";
			this.radioNakit.Size = new System.Drawing.Size(87, 17);
			this.radioNakit.TabIndex = 12;
			this.radioNakit.TabStop = true;
			this.radioNakit.Text = "Nakit Ödeme";
			this.radioNakit.UseVisualStyleBackColor = true;
			// 
			// radioKrediKart
			// 
			this.radioKrediKart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.radioKrediKart.AutoSize = true;
			this.radioKrediKart.Location = new System.Drawing.Point(6, 424);
			this.radioKrediKart.Name = "radioKrediKart";
			this.radioKrediKart.Size = new System.Drawing.Size(73, 17);
			this.radioKrediKart.TabIndex = 11;
			this.radioKrediKart.TabStop = true;
			this.radioKrediKart.Text = "Kredi Kartı";
			this.radioKrediKart.UseVisualStyleBackColor = true;
			// 
			// labelSecilenFiyat
			// 
			this.labelSecilenFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSecilenFiyat.BackColor = System.Drawing.Color.LightSeaGreen;
			this.labelSecilenFiyat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelSecilenFiyat.Location = new System.Drawing.Point(3, 394);
			this.labelSecilenFiyat.Name = "labelSecilenFiyat";
			this.labelSecilenFiyat.Size = new System.Drawing.Size(302, 27);
			this.labelSecilenFiyat.TabIndex = 10;
			this.labelSecilenFiyat.Text = "Seçilen Ürün Fiyatı : 0 TL";
			this.labelSecilenFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblOdenmesiGereken
			// 
			this.LblOdenmesiGereken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LblOdenmesiGereken.BackColor = System.Drawing.Color.DarkGreen;
			this.LblOdenmesiGereken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LblOdenmesiGereken.Location = new System.Drawing.Point(3, 208);
			this.LblOdenmesiGereken.Name = "LblOdenmesiGereken";
			this.LblOdenmesiGereken.Size = new System.Drawing.Size(302, 27);
			this.LblOdenmesiGereken.TabIndex = 9;
			this.LblOdenmesiGereken.Text = "Ödenmesi Gerekn Fiyat : 0 TL";
			this.LblOdenmesiGereken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridSecilen
			// 
			this.dataGridSecilen.AllowUserToAddRows = false;
			this.dataGridSecilen.AllowUserToDeleteRows = false;
			this.dataGridSecilen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridSecilen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridSecilen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridSecilen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridSecilen.Location = new System.Drawing.Point(3, 238);
			this.dataGridSecilen.Name = "dataGridSecilen";
			this.dataGridSecilen.ReadOnly = true;
			this.dataGridSecilen.RowHeadersVisible = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.dataGridSecilen.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridSecilen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridSecilen.Size = new System.Drawing.Size(302, 153);
			this.dataGridSecilen.TabIndex = 6;
			this.dataGridSecilen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSecilen_CellDoubleClick);
			// 
			// dataGridViewSiparis
			// 
			this.dataGridViewSiparis.AllowUserToAddRows = false;
			this.dataGridViewSiparis.AllowUserToDeleteRows = false;
			this.dataGridViewSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewSiparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSiparis.Location = new System.Drawing.Point(3, 16);
			this.dataGridViewSiparis.Name = "dataGridViewSiparis";
			this.dataGridViewSiparis.ReadOnly = true;
			this.dataGridViewSiparis.RowHeadersVisible = false;
			this.dataGridViewSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSiparis.Size = new System.Drawing.Size(302, 151);
			this.dataGridViewSiparis.TabIndex = 0;
			this.dataGridViewSiparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiparis_CellClick);
			this.dataGridViewSiparis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiparis_CellDoubleClick);
			// 
			// labelMasaNo
			// 
			this.labelMasaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.labelMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelMasaNo.ForeColor = System.Drawing.SystemColors.Info;
			this.labelMasaNo.Location = new System.Drawing.Point(520, 6);
			this.labelMasaNo.Name = "labelMasaNo";
			this.labelMasaNo.Size = new System.Drawing.Size(50, 23);
			this.labelMasaNo.TabIndex = 3;
			this.labelMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOdeme
			// 
			this.btnOdeme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOdeme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnOdeme.Image = global::ProjeRestaurant.Properties.Resources.updated_24;
			this.btnOdeme.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOdeme.Location = new System.Drawing.Point(3, 449);
			this.btnOdeme.Name = "btnOdeme";
			this.btnOdeme.Size = new System.Drawing.Size(302, 32);
			this.btnOdeme.TabIndex = 8;
			this.btnOdeme.Text = "ÖDEME GERÇEKLEŞTİR";
			this.btnOdeme.UseVisualStyleBackColor = true;
			this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
			// 
			// FrmSiparisEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(922, 505);
			this.Controls.Add(this.labelMasaNo);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmSiparisEkran";
			this.Text = "FrmSiparisEkran";
			this.Load += new System.EventHandler(this.FrmSiparisEkran_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSecilen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView listViewKategori;
		private System.Windows.Forms.ListView listViewUrunler;
		private System.Windows.Forms.ImageList ımageListKategori;
		private System.Windows.Forms.ImageList ımageListÜrünler;
		private System.Windows.Forms.DataGridView dataGridViewSiparis;
		private System.Windows.Forms.Label labelSecilenFiyat;
		private System.Windows.Forms.Label LblOdenmesiGereken;
		private System.Windows.Forms.Button btnOdeme;
		private System.Windows.Forms.DataGridView dataGridSecilen;
		private System.Windows.Forms.RadioButton radioNakit;
		private System.Windows.Forms.RadioButton radioKrediKart;
		private System.Windows.Forms.Label labelMasaNo;
		private System.Windows.Forms.Button btnMasaIptal;
		private System.Windows.Forms.Button btnSiparisOlustur;
		private System.Windows.Forms.Button button1;
	}
}