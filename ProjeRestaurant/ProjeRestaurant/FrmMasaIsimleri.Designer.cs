namespace ProjeRestaurant
{
	partial class FrmMasaIsimleri
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtMasaNo = new System.Windows.Forms.TextBox();
			this.btnSilMasa = new System.Windows.Forms.Button();
			this.btnGuncelleMasa = new System.Windows.Forms.Button();
			this.btnKaydetMasa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(67, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masa Numarası : ";
			// 
			// txtMasaNo
			// 
			this.txtMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMasaNo.Location = new System.Drawing.Point(177, 28);
			this.txtMasaNo.Name = "txtMasaNo";
			this.txtMasaNo.Size = new System.Drawing.Size(165, 21);
			this.txtMasaNo.TabIndex = 1;
			// 
			// btnSilMasa
			// 
			this.btnSilMasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnSilMasa.Image = global::ProjeRestaurant.Properties.Resources.remove_24;
			this.btnSilMasa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSilMasa.Location = new System.Drawing.Point(281, 68);
			this.btnSilMasa.Name = "btnSilMasa";
			this.btnSilMasa.Size = new System.Drawing.Size(61, 32);
			this.btnSilMasa.TabIndex = 4;
			this.btnSilMasa.Text = "SİL";
			this.btnSilMasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSilMasa.UseVisualStyleBackColor = true;
			this.btnSilMasa.Click += new System.EventHandler(this.btnSilMasa_Click);
			// 
			// btnGuncelleMasa
			// 
			this.btnGuncelleMasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnGuncelleMasa.Image = global::ProjeRestaurant.Properties.Resources.updated_24;
			this.btnGuncelleMasa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuncelleMasa.Location = new System.Drawing.Point(162, 68);
			this.btnGuncelleMasa.Name = "btnGuncelleMasa";
			this.btnGuncelleMasa.Size = new System.Drawing.Size(101, 32);
			this.btnGuncelleMasa.TabIndex = 3;
			this.btnGuncelleMasa.Text = "GÜNCELLE";
			this.btnGuncelleMasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuncelleMasa.UseVisualStyleBackColor = true;
			// 
			// btnKaydetMasa
			// 
			this.btnKaydetMasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnKaydetMasa.Image = global::ProjeRestaurant.Properties.Resources.plus_24;
			this.btnKaydetMasa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKaydetMasa.Location = new System.Drawing.Point(70, 68);
			this.btnKaydetMasa.Name = "btnKaydetMasa";
			this.btnKaydetMasa.Size = new System.Drawing.Size(68, 32);
			this.btnKaydetMasa.TabIndex = 2;
			this.btnKaydetMasa.Text = "EKLE";
			this.btnKaydetMasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKaydetMasa.UseVisualStyleBackColor = true;
			this.btnKaydetMasa.Click += new System.EventHandler(this.btnKaydetMasa_Click);
			// 
			// FrmMasaIsimleri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 131);
			this.Controls.Add(this.btnSilMasa);
			this.Controls.Add(this.btnGuncelleMasa);
			this.Controls.Add(this.btnKaydetMasa);
			this.Controls.Add(this.txtMasaNo);
			this.Controls.Add(this.label1);
			this.Name = "FrmMasaIsimleri";
			this.Text = "FrmMasaIsimleri";
			this.Load += new System.EventHandler(this.FrmMasaIsimleri_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMasaNo;
		private System.Windows.Forms.Button btnKaydetMasa;
		private System.Windows.Forms.Button btnGuncelleMasa;
		private System.Windows.Forms.Button btnSilMasa;
	}
}