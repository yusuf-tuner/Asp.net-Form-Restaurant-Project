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
	public partial class FrmMasalar : Form
	{
		public FrmMasalar()
		{
			InitializeComponent();
		}

		public void doldur()
		{
			using (RestaurantEntities db = new RestaurantEntities())
			{
				listViewMasalar.Items.Clear();
				int i = 0;
				foreach (var item in db.TBLTable.ToList())
				{
					listViewMasalar.Items.Add(item.ID);
					if (item.Status == false)
					{
						listViewMasalar.Items[i].ImageKey = "closeDesk.png";
						i++;
					}
					else
					{
						listViewMasalar.Items[i].ImageKey = "openDesk.png";
						i++;
					}
				}
			}
		}

		private void FrmMasalar_Load(object sender, EventArgs e)
		{
			doldur();

			string yetki = Properties.Settings.Default.UserYetki;

			if (yetki=="Garson" || yetki=="Kasa Görevlisi")
			{
				CMSKategoriler.Enabled = false;
				cmsNotlar.Enabled = false;
				CMSUrunler.Enabled = false;
				CmsKullanici.Enabled = false;
			}
		}

		private void masaEkleCms_Click(object sender, EventArgs e)
		{
			FrmMasaIsimleri masaIslemEkran = new FrmMasaIsimleri();
			if (listViewMasalar.SelectedItems.Count != 0)
			{
				masaIslemEkran.gelenMasa = listViewMasalar.SelectedItems[0].Text;
			}
			else
			{
				masaIslemEkran.gelenMasa = "0";
			}
			masaIslemEkran.Show();
		}

		private void CMSKategoriler_Click(object sender, EventArgs e)
		{
			FrmKategori kategori=new FrmKategori();
			kategori.Show();
		}

		private void CMSUrunler_Click(object sender, EventArgs e)
		{
			FrmUrunler urunler=new FrmUrunler();
			urunler.Show();
		}

		private void sİPARİŞİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmSiparisEkran siparisEkran=new FrmSiparisEkran();
			
			if (listViewMasalar.SelectedItems.Count != 0)
			{
				siparisEkran.MasaNo = listViewMasalar.SelectedItems[0].Text;
			}
			else
			{
				siparisEkran.MasaNo = "0";
			}
			siparisEkran.Show();
		}

		private void cmsNotlar_Click(object sender, EventArgs e)
		{
			FrmNotlar notlar=new FrmNotlar();
			notlar.Show();
		}

		private void CmsKullanici_Click(object sender, EventArgs e)
		{
			FrmKullanici kullanici=new FrmKullanici();
			kullanici.Show();
		}

		private void btnMasaAktar_Click(object sender, EventArgs e)
		{
			FrmKapaliMasa frm=new FrmKapaliMasa();
			
			if (listViewMasalar.SelectedItems.Count!=0)
			{
				frm.masaNo = listViewMasalar.SelectedItems[0].Text; // tıklanan masano yakaladık.
				using (RestaurantEntities db = new RestaurantEntities())
				{
					if (db.TBLTable.Any(x=>x.ID==frm.masaNo && x.Status==false))
					{
						MessageBox.Show("Masa kapalıdır. Taşınamaz.");
					}
					else
					{
						frm.Show();
					}
				}
			}
			
		}

		private void btnOdenenSiparis_Click(object sender, EventArgs e)
		{
			FrmOdenenSiparis frm=new FrmOdenenSiparis();
			frm.Show();
		}
	}
}
