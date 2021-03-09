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
	public partial class FrmKullanici : Form
	{
		private int personelID = 0;
		public FrmKullanici()
		{
			InitializeComponent();
		}

		private void doldur()
		{
			gridPersonelView.Rows.Clear();
			gridPersonelView.ColumnCount = 4;
			gridPersonelView.Columns[0].Name = "ID";
			gridPersonelView.Columns[1].Name = "PersonelAd";
			gridPersonelView.Columns[2].Name = "Şifre";
			gridPersonelView.Columns[3].Name = "Yetki";

			using (RestaurantEntities db = new RestaurantEntities())
			{
				foreach (var personel in db.TBLUser.ToList())
				{
					string[] personels = new string[] { personel.ID.ToString(), personel.Username, personel.Password, personel.Authority };
					gridPersonelView.Rows.Add(personels);
				}
			}

		}

		private void FrmKullanici_Load(object sender, EventArgs e)
		{
			doldur();
		}

		private void btnKaydetUser_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				TBLUser user= new TBLUser();
				user.Username = textPersonelName.Text;
				user.Password = textPersonelPass.Text;
				user.Authority = cmbPersonelAutho.Text;
				db.TBLUser.Add(user);
				db.SaveChanges();
				MessageBox.Show("işlem başarılı");
				textPersonelName.Text = null;
				textPersonelPass.Text = null;
				cmbPersonelAutho.Text = null;
			}
			doldur();
		}

		private void gridPersonelView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			textPersonelName.Text = gridPersonelView.Rows[e.RowIndex].Cells[1].Value.ToString();
			textPersonelPass.Text = gridPersonelView.Rows[e.RowIndex].Cells[2].Value.ToString();
			cmbPersonelAutho.Text = gridPersonelView.Rows[e.RowIndex].Cells[3].Value.ToString();
			personelID = int.Parse(gridPersonelView.Rows[e.RowIndex].Cells[0].Value.ToString());
		}

		private void btnGüncelleUser_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				if (personelID != 0)
				{
					TBLUser userUpdate = db.TBLUser.Find(personelID);
					userUpdate.Username = textPersonelName.Text;
					userUpdate.Authority = cmbPersonelAutho.Text;
					userUpdate.Password = textPersonelPass.Text;
					db.SaveChanges();
					MessageBox.Show("işlem başarılıdır.");
					textPersonelName.Text = null;
					textPersonelPass.Text = null;
					cmbPersonelAutho.Text = null;
				}
				else
					MessageBox.Show("Veri seçmeniz gerekiyor.");
			}
			doldur();
		}

		private void btnSilUser_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				if (personelID!=0)
				{
					TBLUser deleteUser = db.TBLUser.Find(personelID);
					db.TBLUser.Remove(deleteUser);
					db.SaveChanges();
					personelID = 0;
					textPersonelName.Text = null;
					textPersonelPass.Text = null;
					cmbPersonelAutho.Text = null;
				}
				else
				{
					MessageBox.Show("veri seçmediniz.");
				}
			}
			doldur();
		}
	}
}
