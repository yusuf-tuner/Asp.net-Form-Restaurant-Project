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
	public partial class FrmKapaliMasa : Form
	{
		public string masaNo = "";
		public FrmKapaliMasa()
		{
			InitializeComponent();
		}

		private void FrmKapaliMasa_Load(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				int i = 0;
				foreach (var item in db.TBLTable.Where(x=>x.Status==false).ToList())
				{
					KapaliMasaListView.Items.Add(item.ID);
					KapaliMasaListView.Items[i].ImageKey = "closeDesk.png";
					i++;
				}
			}
		
		}

		private void KapaliMasaListView_DoubleClick(object sender, EventArgs e)
		{
			if (KapaliMasaListView.SelectedItems.Count!=0)
			{
				using (RestaurantEntities db =new RestaurantEntities())
				{
					string degistirilmekIstenen = KapaliMasaListView.SelectedItems[0].Text;

					foreach (var item  in db.TBLBasket.Where(x=>x.TableID==masaNo).ToList())
					{
						db.TBLBasket.Find(item.ID).TableID = degistirilmekIstenen;
						db.TBLTable.Find(masaNo).Status = false;
						db.TBLTable.Find(degistirilmekIstenen).Status = true;
						db.SaveChanges();

						FrmMasalar frm = (FrmMasalar) Application.OpenForms["FrmMasalar"];
						if (frm!=null)
						{
							frm.doldur();
						}
						this.Hide();
					}
				}
				
			}

			
		}
	}
}
