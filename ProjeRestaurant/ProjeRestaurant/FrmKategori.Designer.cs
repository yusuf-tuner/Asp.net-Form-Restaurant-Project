namespace ProjeRestaurant
{
	partial class FrmKategori
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
			this.dataGridCategoryView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGüncelle = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.textSira = new System.Windows.Forms.TextBox();
			this.textKategoriName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCategoryView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridCategoryView
			// 
			this.dataGridCategoryView.AllowUserToAddRows = false;
			this.dataGridCategoryView.AllowUserToDeleteRows = false;
			this.dataGridCategoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridCategoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridCategoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCategoryView.Location = new System.Drawing.Point(2, 2);
			this.dataGridCategoryView.MultiSelect = false;
			this.dataGridCategoryView.Name = "dataGridCategoryView";
			this.dataGridCategoryView.ReadOnly = true;
			this.dataGridCategoryView.Size = new System.Drawing.Size(482, 290);
			this.dataGridCategoryView.TabIndex = 0;
			this.dataGridCategoryView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategoryView_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSil);
			this.groupBox1.Controls.Add(this.btnGüncelle);
			this.groupBox1.Controls.Add(this.btnKaydet);
			this.groupBox1.Controls.Add(this.textSira);
			this.groupBox1.Controls.Add(this.textKategoriName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(490, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(317, 290);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bilgiler";
			// 
			// btnSil
			// 
			this.btnSil.Image = global::ProjeRestaurant.Properties.Resources.remove_24;
			this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSil.Location = new System.Drawing.Point(237, 146);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(65, 36);
			this.btnSil.TabIndex = 8;
			this.btnSil.Text = "SİL";
			this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGüncelle
			// 
			this.btnGüncelle.Image = global::ProjeRestaurant.Properties.Resources.updated_24;
			this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGüncelle.Location = new System.Drawing.Point(116, 146);
			this.btnGüncelle.Name = "btnGüncelle";
			this.btnGüncelle.Size = new System.Drawing.Size(115, 36);
			this.btnGüncelle.TabIndex = 7;
			this.btnGüncelle.Text = "GÜNCELLE";
			this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGüncelle.UseVisualStyleBackColor = true;
			this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Image = global::ProjeRestaurant.Properties.Resources.plus_24;
			this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKaydet.Location = new System.Drawing.Point(9, 146);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(101, 36);
			this.btnKaydet.TabIndex = 6;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// textSira
			// 
			this.textSira.Location = new System.Drawing.Point(9, 95);
			this.textSira.Name = "textSira";
			this.textSira.Size = new System.Drawing.Size(155, 22);
			this.textSira.TabIndex = 5;
			// 
			// textKategoriName
			// 
			this.textKategoriName.Location = new System.Drawing.Point(9, 42);
			this.textKategoriName.Name = "textKategoriName";
			this.textKategoriName.Size = new System.Drawing.Size(155, 22);
			this.textKategoriName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Liste Sırası :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kategori Adı :";
			// 
			// FrmKategori
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 296);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridCategoryView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmKategori";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmKategori";
			this.Load += new System.EventHandler(this.FrmKategori_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCategoryView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridCategoryView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textKategoriName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGüncelle;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.TextBox textSira;
	}
}