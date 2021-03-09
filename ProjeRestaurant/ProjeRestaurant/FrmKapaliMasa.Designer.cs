namespace ProjeRestaurant
{
	partial class FrmKapaliMasa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKapaliMasa));
			this.KapaliMasaListView = new System.Windows.Forms.ListView();
			this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// KapaliMasaListView
			// 
			this.KapaliMasaListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.KapaliMasaListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.KapaliMasaListView.HideSelection = false;
			this.KapaliMasaListView.HoverSelection = true;
			this.KapaliMasaListView.LargeImageList = this.ımageList1;
			this.KapaliMasaListView.Location = new System.Drawing.Point(0, 0);
			this.KapaliMasaListView.Name = "KapaliMasaListView";
			this.KapaliMasaListView.Size = new System.Drawing.Size(800, 450);
			this.KapaliMasaListView.TabIndex = 0;
			this.KapaliMasaListView.UseCompatibleStateImageBehavior = false;
			this.KapaliMasaListView.DoubleClick += new System.EventHandler(this.KapaliMasaListView_DoubleClick);
			// 
			// ımageList1
			// 
			this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
			this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ımageList1.Images.SetKeyName(0, "closeDesk.png");
			// 
			// FrmKapaliMasa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.KapaliMasaListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmKapaliMasa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmKapaliMasa";
			this.Load += new System.EventHandler(this.FrmKapaliMasa_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView KapaliMasaListView;
		private System.Windows.Forms.ImageList ımageList1;
	}
}