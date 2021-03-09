namespace ProjeRestaurant
{
	partial class FrmNotlar
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
			this.btnDeleteNote = new System.Windows.Forms.Button();
			this.btnUpdateNote = new System.Windows.Forms.Button();
			this.btnAddNote = new System.Windows.Forms.Button();
			this.textNote = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridNotesView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridNotesView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDeleteNote);
			this.groupBox1.Controls.Add(this.btnUpdateNote);
			this.groupBox1.Controls.Add(this.btnAddNote);
			this.groupBox1.Controls.Add(this.textNote);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(491, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(317, 290);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bilgiler";
			// 
			// btnDeleteNote
			// 
			this.btnDeleteNote.Image = global::ProjeRestaurant.Properties.Resources.remove_24;
			this.btnDeleteNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteNote.Location = new System.Drawing.Point(237, 248);
			this.btnDeleteNote.Name = "btnDeleteNote";
			this.btnDeleteNote.Size = new System.Drawing.Size(65, 36);
			this.btnDeleteNote.TabIndex = 8;
			this.btnDeleteNote.Text = "SİL";
			this.btnDeleteNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDeleteNote.UseVisualStyleBackColor = true;
			this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
			// 
			// btnUpdateNote
			// 
			this.btnUpdateNote.Image = global::ProjeRestaurant.Properties.Resources.updated_24;
			this.btnUpdateNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdateNote.Location = new System.Drawing.Point(116, 248);
			this.btnUpdateNote.Name = "btnUpdateNote";
			this.btnUpdateNote.Size = new System.Drawing.Size(115, 36);
			this.btnUpdateNote.TabIndex = 7;
			this.btnUpdateNote.Text = "GÜNCELLE";
			this.btnUpdateNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdateNote.UseVisualStyleBackColor = true;
			this.btnUpdateNote.Click += new System.EventHandler(this.btnUpdateNote_Click);
			// 
			// btnAddNote
			// 
			this.btnAddNote.Image = global::ProjeRestaurant.Properties.Resources.plus_24;
			this.btnAddNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddNote.Location = new System.Drawing.Point(9, 248);
			this.btnAddNote.Name = "btnAddNote";
			this.btnAddNote.Size = new System.Drawing.Size(101, 36);
			this.btnAddNote.TabIndex = 6;
			this.btnAddNote.Text = "KAYDET";
			this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddNote.UseVisualStyleBackColor = true;
			this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
			// 
			// textNote
			// 
			this.textNote.Location = new System.Drawing.Point(9, 42);
			this.textNote.Multiline = true;
			this.textNote.Name = "textNote";
			this.textNote.Size = new System.Drawing.Size(293, 201);
			this.textNote.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Notunuz :";
			// 
			// dataGridNotesView
			// 
			this.dataGridNotesView.AllowUserToAddRows = false;
			this.dataGridNotesView.AllowUserToDeleteRows = false;
			this.dataGridNotesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridNotesView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridNotesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridNotesView.Location = new System.Drawing.Point(3, 6);
			this.dataGridNotesView.MultiSelect = false;
			this.dataGridNotesView.Name = "dataGridNotesView";
			this.dataGridNotesView.ReadOnly = true;
			this.dataGridNotesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridNotesView.Size = new System.Drawing.Size(482, 290);
			this.dataGridNotesView.TabIndex = 2;
			this.dataGridNotesView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNotesView_CellDoubleClick);
			// 
			// FrmNotlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 300);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridNotesView);
			this.Name = "FrmNotlar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmNotlar";
			this.Load += new System.EventHandler(this.FrmNotlar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridNotesView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDeleteNote;
		private System.Windows.Forms.Button btnUpdateNote;
		private System.Windows.Forms.Button btnAddNote;
		private System.Windows.Forms.TextBox textNote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridNotesView;
	}
}