namespace ProjeRestaurant
{
	partial class FrmKullanici
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
			this.btnSilUser = new System.Windows.Forms.Button();
			this.btnGüncelleUser = new System.Windows.Forms.Button();
			this.btnKaydetUser = new System.Windows.Forms.Button();
			this.textPersonelPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbPersonelAutho = new System.Windows.Forms.ComboBox();
			this.textPersonelName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridPersonelView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPersonelView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnSilUser);
			this.groupBox1.Controls.Add(this.btnGüncelleUser);
			this.groupBox1.Controls.Add(this.btnKaydetUser);
			this.groupBox1.Controls.Add(this.textPersonelPass);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbPersonelAutho);
			this.groupBox1.Controls.Add(this.textPersonelName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(6, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(644, 159);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Bilgileri";
			// 
			// btnSilUser
			// 
			this.btnSilUser.Image = global::ProjeRestaurant.Properties.Resources.remove_24;
			this.btnSilUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSilUser.Location = new System.Drawing.Point(569, 113);
			this.btnSilUser.Name = "btnSilUser";
			this.btnSilUser.Size = new System.Drawing.Size(65, 36);
			this.btnSilUser.TabIndex = 11;
			this.btnSilUser.Text = "SİL";
			this.btnSilUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSilUser.UseVisualStyleBackColor = true;
			this.btnSilUser.Click += new System.EventHandler(this.btnSilUser_Click);
			// 
			// btnGüncelleUser
			// 
			this.btnGüncelleUser.Image = global::ProjeRestaurant.Properties.Resources.updated_24;
			this.btnGüncelleUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGüncelleUser.Location = new System.Drawing.Point(448, 113);
			this.btnGüncelleUser.Name = "btnGüncelleUser";
			this.btnGüncelleUser.Size = new System.Drawing.Size(115, 36);
			this.btnGüncelleUser.TabIndex = 10;
			this.btnGüncelleUser.Text = "GÜNCELLE";
			this.btnGüncelleUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGüncelleUser.UseVisualStyleBackColor = true;
			this.btnGüncelleUser.Click += new System.EventHandler(this.btnGüncelleUser_Click);
			// 
			// btnKaydetUser
			// 
			this.btnKaydetUser.Image = global::ProjeRestaurant.Properties.Resources.plus_24;
			this.btnKaydetUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKaydetUser.Location = new System.Drawing.Point(341, 113);
			this.btnKaydetUser.Name = "btnKaydetUser";
			this.btnKaydetUser.Size = new System.Drawing.Size(101, 36);
			this.btnKaydetUser.TabIndex = 9;
			this.btnKaydetUser.Text = "KAYDET";
			this.btnKaydetUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnKaydetUser.UseVisualStyleBackColor = true;
			this.btnKaydetUser.Click += new System.EventHandler(this.btnKaydetUser_Click);
			// 
			// textPersonelPass
			// 
			this.textPersonelPass.Location = new System.Drawing.Point(18, 84);
			this.textPersonelPass.Name = "textPersonelPass";
			this.textPersonelPass.Size = new System.Drawing.Size(146, 22);
			this.textPersonelPass.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Personel Şifre :";
			// 
			// cmbPersonelAutho
			// 
			this.cmbPersonelAutho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPersonelAutho.FormattingEnabled = true;
			this.cmbPersonelAutho.Items.AddRange(new object[] {
            "Garson",
            "Yönetici",
            "Kasa Görevlisi"});
			this.cmbPersonelAutho.Location = new System.Drawing.Point(20, 125);
			this.cmbPersonelAutho.Name = "cmbPersonelAutho";
			this.cmbPersonelAutho.Size = new System.Drawing.Size(146, 24);
			this.cmbPersonelAutho.TabIndex = 3;
			// 
			// textPersonelName
			// 
			this.textPersonelName.Location = new System.Drawing.Point(18, 41);
			this.textPersonelName.Name = "textPersonelName";
			this.textPersonelName.Size = new System.Drawing.Size(146, 22);
			this.textPersonelName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Yetkilendirme :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personel Adı :";
			// 
			// gridPersonelView
			// 
			this.gridPersonelView.AllowUserToAddRows = false;
			this.gridPersonelView.AllowUserToDeleteRows = false;
			this.gridPersonelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridPersonelView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridPersonelView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gridPersonelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPersonelView.Location = new System.Drawing.Point(6, 168);
			this.gridPersonelView.Name = "gridPersonelView";
			this.gridPersonelView.ReadOnly = true;
			this.gridPersonelView.Size = new System.Drawing.Size(643, 306);
			this.gridPersonelView.TabIndex = 1;
			this.gridPersonelView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPersonelView_CellDoubleClick);
			// 
			// FrmKullanici
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 477);
			this.Controls.Add(this.gridPersonelView);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmKullanici";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmKullanici";
			this.Load += new System.EventHandler(this.FrmKullanici_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPersonelView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textPersonelPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPersonelAutho;
		private System.Windows.Forms.TextBox textPersonelName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridPersonelView;
		private System.Windows.Forms.Button btnSilUser;
		private System.Windows.Forms.Button btnGüncelleUser;
		private System.Windows.Forms.Button btnKaydetUser;
	}
}