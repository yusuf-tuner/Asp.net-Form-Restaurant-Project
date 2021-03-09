using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeRestaurant.DataBase;

namespace ProjeRestaurant
{
	public partial class FrmKategori : Form
	{
		private int dataID = 0;
		public FrmKategori()
		{
			InitializeComponent();
		}

		private void doldur()
		{
			dataGridCategoryView.Rows.Clear();
			dataGridCategoryView.ColumnCount = 3;
			dataGridCategoryView.Columns[0].Name = "ID";
			dataGridCategoryView.Columns[1].Name = "Kategori";
			dataGridCategoryView.Columns[2].Name = "Sırası";
			using (RestaurantEntities db=new RestaurantEntities())
			{
				foreach (var x in db.TBLCategori.ToList())
				{
					string[] categoryList=new string[]{x.ID.ToString(),x.Name,x.Desk.ToString()};
					dataGridCategoryView.Rows.Add(categoryList);
				}
			}
		}

		private void FrmKategori_Load(object sender, EventArgs e)
		{
			doldur();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				TBLCategori categories=new TBLCategori();
				categories.Name = textKategoriName.Text;
				categories.Desk = int.Parse(textSira.Text);
				db.TBLCategori.Add(categories);
				db.SaveChanges();
				MessageBox.Show("işlem başarılı.");
			}
			doldur();
		}

		private void dataGridCategoryView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			textKategoriName.Text = dataGridCategoryView.Rows[e.RowIndex].Cells[1].Value.ToString();
			textSira.Text = dataGridCategoryView.Rows[e.RowIndex].Cells[2].Value.ToString();
			dataID = int.Parse(dataGridCategoryView.Rows[e.RowIndex].Cells[0].Value.ToString());
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities dbEntities=new RestaurantEntities())
			{
				if (dataID != 0)
				{
					TBLCategori note = dbEntities.TBLCategori.Find(dataID);
					note.Name = textKategoriName.Text;
					note.Desk = int.Parse(textSira.Text);
					dbEntities.SaveChanges();
					MessageBox.Show("İşlem başarılı.");
				}
				else
					MessageBox.Show("Veri Seçmeniz gerekiyor.");
			}

			doldur();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				if (dataID != 0)
				{
					TBLCategori deleteNote = db.TBLCategori.Find(dataID);
					db.TBLCategori.Remove(deleteNote);
					db.SaveChanges();
					dataID = 0;
					textKategoriName.Text = null;
					textSira.Text = null;
					MessageBox.Show("işlem başarılı.");
				}
				else
					MessageBox.Show("Veri seçmeniz gerekiyor.");
			}

			doldur();
		}
	}
}
