namespace ProjeRestaurant
{
	partial class FrmUrunler
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbResim = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textIcerik = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mskTextPrice = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbCategoryName = new System.Windows.Forms.ComboBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.textProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridUrunKategori = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridUrunKategori)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbResim);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textIcerik);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.mskTextPrice);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbCategoryName);
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGuncelle);
			this.groupBox1.Controls.Add(this.btnKaydet);
			this.groupBox1.Controls.Add(this.textProductName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(631, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(317, 368);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bilgiler";
			// 
			// cmbResim
			// 
			this.cmbResim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbResim.FormattingEnabled = true;
			this.cmbResim.Items.AddRange(new object[] {
            "kahvalti.jpg",
            "makarna.jpg",
            "salata.jpg",
            "tatli.jpg",
            "corba.jpg",
            "icecek.jpg"});
			this.cmbResim.Location = new System.Drawing.Point(9, 258);
			this.cmbResim.Name = "cmbResim";
			this.cmbResim.Size = new System.Drawing.Size(293, 24);
			this.cmbResim.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 16);
			this.label5.TabIndex = 14;
			this.label5.Text = "Ürün Resmi :";
			// 
			// textIcerik
			// 
			this.textIcerik.Location = new System.Drawing.Point(9, 205);
			this.textIcerik.Name = "textIcerik";
			this.textIcerik.Size = new System.Drawing.Size(293, 22);
			this.textIcerik.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Ürün İçeriği :";
			// 
			// mskTextPrice
			// 
			this.mskTextPrice.Location = new System.Drawing.Point(9, 152);
			this.mskTextPrice.Name = "mskTextPrice";
			this.mskTextPrice.Size = new System.Drawing.Size(293, 22);
			this.mskTextPrice.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Fiyatı :";
			// 
			// cmbCategoryName
			// 
			this.cmbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoryName.FormattingEnabled = true;
			this.cmbCategoryName.Location = new System.Drawing.Point(9, 96);
			this.cmbCategoryName.Name = "cmbCategoryName";
			this.cmbCategoryName.Size = new System.Drawing.Size(293, 24);
			this.cmbCategoryName.TabIndex = 9;
			// 
			// btnSil
			// 
			this.btnSil.Image = global::ProjeRestaurant.Properties.Resources.remove_24;
			this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSil.Location = new System.Drawing.Point(237, 321);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(65, 36);
			this.btnSil.TabIndex = 8;
			this.btnSil.Text = "SİL";
			this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Image = global::ProjeRestaurant.Properties.Resources.updated_24;
			this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuncelle.Location = new System.Drawing.Point(116, 321);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(115, 36);
			this.btnGuncelle.TabIndex = 7;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Image = global::ProjeRestaurant.Properties.Resources.plus_24;
			this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKaydet.Location = new System.Drawing.Point(9, 321);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(101, 36);
			this.btnKaydet.TabIndex = 6;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// textProductName
			// 
			this.textProductName.Location = new System.Drawing.Point(9, 42);
			this.textProductName.Name = "textProductName";
			this.textProductName.Size = new System.Drawing.Size(293, 22);
			this.textProductName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kategori Adı :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ürün Adı :";
			// 
			// dataGridUrunKategori
			// 
			this.dataGridUrunKategori.AllowUserToAddRows = false;
			this.dataGridUrunKategori.AllowUserToDeleteRows = false;
			this.dataGridUrunKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridUrunKategori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridUrunKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridUrunKategori.Location = new System.Drawing.Point(3, 6);
			this.dataGridUrunKategori.MultiSelect = false;
			this.dataGridUrunKategori.Name = "dataGridUrunKategori";
			this.dataGridUrunKategori.ReadOnly = true;
			this.dataGridUrunKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridUrunKategori.Size = new System.Drawing.Size(622, 368);
			this.dataGridUrunKategori.TabIndex = 2;
			this.dataGridUrunKategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUrunKategori_CellDoubleClick);
			// 
			// FrmUrunler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 382);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridUrunKategori);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmUrunler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmUrunler";
			this.Load += new System.EventHandler(this.FrmUrunler_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridUrunKategori)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.TextBox textProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridUrunKategori;
		private System.Windows.Forms.MaskedTextBox mskTextPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbCategoryName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textIcerik;
		private System.Windows.Forms.ComboBox cmbResim;
	}
}