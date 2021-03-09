namespace ProjeRestaurant
{
	partial class FrmMasalar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasalar));
			this.listViewMasalar = new System.Windows.Forms.ListView();
			this.CmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CMSKategoriler = new System.Windows.Forms.ToolStripMenuItem();
			this.CMSUrunler = new System.Windows.Forms.ToolStripMenuItem();
			this.sİPARİŞİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsNotlar = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsKullanici = new System.Windows.Forms.ToolStripMenuItem();
			this.MasaResimler = new System.Windows.Forms.ImageList(this.components);
			this.btnMasaAktar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.btnOdenenSiparis = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsRightClick.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewMasalar
			// 
			this.listViewMasalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewMasalar.ContextMenuStrip = this.CmsRightClick;
			this.listViewMasalar.HideSelection = false;
			this.listViewMasalar.LargeImageList = this.MasaResimler;
			this.listViewMasalar.Location = new System.Drawing.Point(12, 12);
			this.listViewMasalar.Name = "listViewMasalar";
			this.listViewMasalar.Size = new System.Drawing.Size(765, 416);
			this.listViewMasalar.TabIndex = 0;
			this.listViewMasalar.UseCompatibleStateImageBehavior = false;
			// 
			// CmsRightClick
			// 
			this.CmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSKategoriler,
            this.CMSUrunler,
            this.sİPARİŞİŞLEMLERİToolStripMenuItem,
            this.cmsNotlar,
            this.CmsKullanici,
            this.btnMasaAktar,
            this.toolStripMenuItem1,
            this.btnOdenenSiparis});
			this.CmsRightClick.Name = "CmsRightClick";
			this.CmsRightClick.Size = new System.Drawing.Size(183, 180);
			// 
			// CMSKategoriler
			// 
			this.CMSKategoriler.Name = "CMSKategoriler";
			this.CMSKategoriler.Size = new System.Drawing.Size(182, 22);
			this.CMSKategoriler.Text = "KATEGORİLER";
			this.CMSKategoriler.Click += new System.EventHandler(this.CMSKategoriler_Click);
			// 
			// CMSUrunler
			// 
			this.CMSUrunler.Name = "CMSUrunler";
			this.CMSUrunler.Size = new System.Drawing.Size(182, 22);
			this.CMSUrunler.Text = "ÜRÜNLER";
			this.CMSUrunler.Click += new System.EventHandler(this.CMSUrunler_Click);
			// 
			// sİPARİŞİŞLEMLERİToolStripMenuItem
			// 
			this.sİPARİŞİŞLEMLERİToolStripMenuItem.Name = "sİPARİŞİŞLEMLERİToolStripMenuItem";
			this.sİPARİŞİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.sİPARİŞİŞLEMLERİToolStripMenuItem.Text = "SİPARİŞ iŞLEMLERİ";
			this.sİPARİŞİŞLEMLERİToolStripMenuItem.Click += new System.EventHandler(this.sİPARİŞİŞLEMLERİToolStripMenuItem_Click);
			// 
			// cmsNotlar
			// 
			this.cmsNotlar.Name = "cmsNotlar";
			this.cmsNotlar.Size = new System.Drawing.Size(182, 22);
			this.cmsNotlar.Text = "NOTLARIM";
			this.cmsNotlar.Click += new System.EventHandler(this.cmsNotlar_Click);
			// 
			// CmsKullanici
			// 
			this.CmsKullanici.Name = "CmsKullanici";
			this.CmsKullanici.Size = new System.Drawing.Size(182, 22);
			this.CmsKullanici.Text = "KULLANICILAR";
			this.CmsKullanici.Click += new System.EventHandler(this.CmsKullanici_Click);
			// 
			// MasaResimler
			// 
			this.MasaResimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MasaResimler.ImageStream")));
			this.MasaResimler.TransparentColor = System.Drawing.Color.Transparent;
			this.MasaResimler.Images.SetKeyName(0, "closeDesk.png");
			this.MasaResimler.Images.SetKeyName(1, "openDesk.png");
			// 
			// btnMasaAktar
			// 
			this.btnMasaAktar.Name = "btnMasaAktar";
			this.btnMasaAktar.Size = new System.Drawing.Size(182, 22);
			this.btnMasaAktar.Text = "MASA AKTAR";
			this.btnMasaAktar.Click += new System.EventHandler(this.btnMasaAktar_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			// 
			// btnOdenenSiparis
			// 
			this.btnOdenenSiparis.Name = "btnOdenenSiparis";
			this.btnOdenenSiparis.Size = new System.Drawing.Size(182, 22);
			this.btnOdenenSiparis.Text = "ÖDENEN SİPARİŞLER";
			this.btnOdenenSiparis.Click += new System.EventHandler(this.btnOdenenSiparis_Click);
			// 
			// FrmMasalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listViewMasalar);
			this.Name = "FrmMasalar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMasalar";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmMasalar_Load);
			this.CmsRightClick.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listViewMasalar;
		private System.Windows.Forms.ImageList MasaResimler;
		private System.Windows.Forms.ContextMenuStrip CmsRightClick;
		private System.Windows.Forms.ToolStripMenuItem CMSKategoriler;
		private System.Windows.Forms.ToolStripMenuItem CMSUrunler;
		private System.Windows.Forms.ToolStripMenuItem sİPARİŞİŞLEMLERİToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cmsNotlar;
		private System.Windows.Forms.ToolStripMenuItem CmsKullanici;
		private System.Windows.Forms.ToolStripMenuItem btnMasaAktar;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem btnOdenenSiparis;
	}
}