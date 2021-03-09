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
	public partial class FrmMasaIsimleri : Form
	{
		public FrmMasaIsimleri()
		{
			InitializeComponent();
		}

		private void btnKaydetMasa_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				if (db.TBLTable.Any(x=>x.ID==txtMasaNo.Text))
				{
					MessageBox.Show("Eklemek istediğiniz masa sistemde bulunmaktadır.");
				}
				else
				{
					TBLTable masa = new TBLTable();
					masa.ID = txtMasaNo.Text;
					masa.Status = false;
					db.TBLTable.Add(masa);
					db.SaveChanges();
					MessageBox.Show("Masa ekleme İşlemi Başarılı");
					this.Hide();
				}

				
				// FrmMasalar ekranı açıkmı kontrolü yapıyoruz.
				FrmMasalar frm = (FrmMasalar)Application.OpenForms["FrmMasalar"];
				if (frm!=null)
				{
					frm.doldur();
				}
				else
				{
					FrmMasalar frm2=new FrmMasalar();
					frm2.Show();
				}
			}
		}

		public string gelenMasa = "0";

		private void FrmMasaIsimleri_Load(object sender, EventArgs e)
		{
			if (gelenMasa=="0")
			{
				btnGuncelleMasa.Enabled = false;
				btnSilMasa.Enabled = false;
			}
			else
			{
				btnKaydetMasa.Enabled = false;
				txtMasaNo.Text = gelenMasa;
			}
		}

		private void btnSilMasa_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				if (db.TBLTable.Any(x=>x.ID==txtMasaNo.Text && x.Status==false))
				{
					db.TBLTable.Remove(db.TBLTable.Find(txtMasaNo.Text));
					db.SaveChanges();
					this.Hide();
					FrmMasalar frm = (FrmMasalar)Application.OpenForms["FrmMasalar"];
					if (frm != null)
					{
						frm.doldur();
					}
					else
					{
						FrmMasalar frm2 = new FrmMasalar();
						frm2.Show();
					}
				}
				else
				{
					MessageBox.Show("Masada Sipariş Bulunmaktadır.!!!");
				}
			}
		}
	}
}
