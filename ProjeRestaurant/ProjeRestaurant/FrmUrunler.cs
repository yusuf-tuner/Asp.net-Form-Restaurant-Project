using System;
using System.Linq;
using System.Windows.Forms;
using ProjeRestaurant.DataBase;

namespace ProjeRestaurant
{
	public partial class FrmUrunler : Form
	{
		private int productID = 0;
		public FrmUrunler()
		{
			InitializeComponent();
		}

		private void doldur()
		{
			dataGridUrunKategori.Rows.Clear();
			dataGridUrunKategori.ColumnCount = 6;
			dataGridUrunKategori.Columns[0].Name = "ID";
			dataGridUrunKategori.Columns[1].Name = "Ürün Adı";
			dataGridUrunKategori.Columns[2].Name = "Kategori";
			dataGridUrunKategori.Columns[3].Name = "Fiyat";
			dataGridUrunKategori.Columns[4].Name = "İçeriği";
			dataGridUrunKategori.Columns[5].Name = "Resmi";

			using (RestaurantEntities db=new RestaurantEntities())
			{
				foreach (var item in db.TBLProduct.ToList())
				{
					string price = Convert.ToDecimal(item.Price).ToString("N");
					string KategoriAd = db.TBLCategori.Where(x => x.ID == item.CategoriesID).FirstOrDefault().Name;
					string[] urunStrings=new string[]
					{
						item.ID.ToString(),
						item.Name,
						KategoriAd,
						price,
						item.SubContent,
						item.Images,
					};
					dataGridUrunKategori.Rows.Add(urunStrings);
				}
			}
		}

		private void ClearCells()
		{
			textProductName.Text = null;
			textIcerik.Text = null;
			cmbCategoryName.Text = null;
			mskTextPrice.Text = null;
			cmbResim.Text = null;
		}

		private void FrmUrunler_Load(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				cmbCategoryName.DataSource = db.TBLCategori.ToList();
				cmbCategoryName.DisplayMember = "Name"; // kullanıcın gördüğü tarafa
				cmbCategoryName.ValueMember = "ID";		// yazılım tarafında ıd göre tutulan alan
				
				doldur();
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				TBLProduct p=new TBLProduct();
				p.Name = textProductName.Text;
				p.SubContent = textIcerik.Text;
				p.CategoriesID = int.Parse(cmbCategoryName.SelectedValue.ToString());
				p.Price = decimal.Parse(mskTextPrice.Text);
				p.Images = cmbResim.Text;
				db.TBLProduct.Add(p);
				db.SaveChanges();
				MessageBox.Show("işlem başarılı");

				ClearCells();
			}
			doldur();
		}

		private void dataGridUrunKategori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			textProductName.Text = dataGridUrunKategori.Rows[e.RowIndex].Cells[1].Value.ToString();
			cmbCategoryName.Text = dataGridUrunKategori.Rows[e.RowIndex].Cells[2].Value.ToString();
			mskTextPrice.Text = dataGridUrunKategori.Rows[e.RowIndex].Cells[3].Value.ToString();
			textIcerik.Text = dataGridUrunKategori.Rows[e.RowIndex].Cells[4].Value.ToString();
			cmbResim.Text = dataGridUrunKategori.Rows[e.RowIndex].Cells[5].Value.ToString();
			productID = int.Parse(dataGridUrunKategori.Rows[e.RowIndex].Cells[0].Value.ToString());
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (productID != 0)
			{
				using (RestaurantEntities db = new RestaurantEntities())
				{
					TBLProduct updateProduct = db.TBLProduct.Find(productID);
					updateProduct.Name = textProductName.Text;
					updateProduct.SubContent = textIcerik.Text;
					updateProduct.CategoriesID = int.Parse(cmbCategoryName.SelectedValue.ToString());
					updateProduct.Price = decimal.Parse(mskTextPrice.Text);
					updateProduct.Images = cmbResim.Text;
					db.SaveChanges();
					MessageBox.Show("İşlem Başarılıdır.");
					ClearCells();
				}
			}
			else
			{
				MessageBox.Show("Veri Seçmediniz.");
			}
			
			doldur();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (productID != 0)
			{
				using (RestaurantEntities db = new RestaurantEntities())
				{
					TBLProduct deleteProduct = db.TBLProduct.Find(productID);
					db.TBLProduct.Remove(deleteProduct);
					db.SaveChanges();
					productID = 0;
					MessageBox.Show("işlem başarılıdır.");
					ClearCells();
				}
				
			}
			else
			{
				MessageBox.Show("Veri Seçmediniz.");
			}
			doldur();
		}
	}
}
