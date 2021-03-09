using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeRestaurant.DataBase;

namespace ProjeRestaurant
{
	public partial class FrmSiparisEkran : Form
	{
		public FrmSiparisEkran()
		{
			InitializeComponent();
		}

		public string MasaNo = "";
		//Ram üzerinde sanal tablo oluşturarak ödeme işlemleri kısmını yapıyoruz.
		DataTable table = new DataTable();
		List<SiparisSepet> sepet = new List<SiparisSepet>();
		List<SiparisSepet> secilen = new List<SiparisSepet>();
		private int siparisID = 0;

		private void FrmSiparisEkran_Load(object sender, EventArgs e)
		{
			using (RestaurantEntities db = new RestaurantEntities())    // daha önce oluşturulmuş sipariş bilgilerini getiriyoruz.
			{
				if (db.TBLTable.Any(x => x.ID == MasaNo && x.Status == true))
				{
					foreach (var item in db.TBLBasket.Where(x => x.TableID == MasaNo))
					{
						SiparisSepet s = new SiparisSepet();
						s.Adet = (int)item.Piece;
						s.Fiyat = Convert.ToDecimal(item.Price).ToString("N");
						s.Urun = item.Name;
						s.ID = (int)item.ProductID;
						sepet.Add(s);
					}

					dataGridViewSiparis.DataSource = sepet;
				}
			}


			labelMasaNo.Text = MasaNo;

			using (RestaurantEntities db = new RestaurantEntities())
			{
				int k = 0;
				foreach (var item in db.TBLCategori.ToList())
				{
					listViewKategori.Items.Add(item.Name);
					listViewKategori.Items[k].ImageKey = "category.png";
					k++;
				}



				int i = 0;
				foreach (var item in db.TBLProduct.ToList())
				{
					listViewUrunler.Items.Add(item.Name);
					listViewUrunler.Items[i].ImageKey = item.Images;
					i++;
				}
			}

			string yetki = Properties.Settings.Default.UserYetki;

			if (yetki == "Garson")
			{
				btnOdeme.Enabled = false;
			}



		}

		private void listViewKategori_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db = new RestaurantEntities())
			{
				string tiklanan = listViewKategori.SelectedItems[0].Text;
				int secilenKategori = db.TBLCategori.Where(x => x.Name == tiklanan).FirstOrDefault().ID;

				listViewUrunler.Items.Clear();
				int i = 0;
				foreach (var item in db.TBLProduct.Where(x => x.CategoriesID == secilenKategori).ToList())
				{
					listViewUrunler.Items.Add(item.Name);
					listViewUrunler.Items[i].ImageKey = item.Images;
					i++;
				}
			}
		}

		private void listViewUrunler_DoubleClick(object sender, EventArgs e)
		{
			using (RestaurantEntities db = new RestaurantEntities())
			{

				string tiklanan = listViewUrunler.SelectedItems[0].Text;
				var data = db.TBLProduct.Where(x => x.Name == tiklanan).FirstOrDefault();

				if (sepet.Any(x => x.ID == data.ID))
				{
					sepet.Where(x => x.ID == data.ID).FirstOrDefault().Adet++;
				}
				else
				{
					SiparisSepet s = new SiparisSepet();
					s.Adet = 1;
					s.Fiyat = Convert.ToDecimal(data.Price).ToString("N");
					s.Urun = data.Name;
					s.ID = data.ID;
					sepet.Add(s);
				}
			}


			dataGridViewSiparis.DataSource = sepet.ToList();

			decimal toplam = 0;
			foreach (var item in sepet.ToList())
			{
				toplam += item.Adet * Convert.ToDecimal(item.Fiyat);
			}

			LblOdenmesiGereken.Text = "Ödenmesi Gereken Fiyat : " + toplam.ToString("C");

		}

		private void dataGridViewSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				siparisID = Convert.ToInt32(dataGridViewSiparis.Rows[e.RowIndex].Cells[0].Value.ToString());

			}
		}

		private void btnSiparisOlustur_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db = new RestaurantEntities())
			{
				if (db.TBLTable.Any(x => x.Status == false && x.ID == MasaNo)) // masada sipariş yoksa sipariş giriliyor.
				{
					if (sepet.Count == 0)
					{
						MessageBox.Show("masaya sipariş girilmemiştir.");
					}
					else
					{
						foreach (var item in sepet.ToList())
						{
							TBLBasket b = new TBLBasket();
							b.TableID = MasaNo;
							b.ProductID = item.ID;
							b.Price = Convert.ToDecimal(item.Fiyat);
							b.Piece = item.Adet;
							b.Name = item.Urun;
							db.TBLBasket.Add(b);
							db.SaveChanges();

						}
						MessageBox.Show("sipariş oluşturuldu.");
						db.TBLTable.Where(x => x.ID == MasaNo).FirstOrDefault().Status = true;
						db.SaveChanges();

						FrmMasalar frm = (FrmMasalar)Application.OpenForms["FrmMasalar"];
						if (frm != null)
						{
							frm.doldur();
						}

						this.Hide();
					}
				}
				else // açık masadaki siparişler üzerinde işlem yapılıyor.
				{
					foreach (var item in db.TBLBasket.Where(x => x.TableID == MasaNo).ToList())
					{
						db.TBLBasket.Remove(db.TBLBasket.Find(item.ID));    //masaya ait tüm siparişler siliniyor.
						db.SaveChanges();
					}

					foreach (var item in sepet.ToList())
					{
						TBLBasket b = new TBLBasket();
						b.TableID = MasaNo;
						b.ProductID = item.ID;
						b.Price = Convert.ToDecimal(item.Fiyat);
						b.Piece = item.Adet;
						b.Name = item.Urun;
						db.TBLBasket.Add(b);
						db.SaveChanges();
					}

					MessageBox.Show("Sipariş Bilgileri Güncellendi.");
				}
			}
		}

		private void dataGridViewSiparis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int TiklananID = int.Parse(dataGridViewSiparis.Rows[e.RowIndex].Cells[0].Value.ToString());

			// odenmek istenen ürün değişkene atanıyor.
			var OdenmekIstenenUrun = sepet.Where(x => x.ID == TiklananID).FirstOrDefault();
			//odenmek istenen ürün secilen ekranına gönderiliyor. ve sepet tarafından siliniyor.
			secilen.Add(OdenmekIstenenUrun);
			sepet.Remove(OdenmekIstenenUrun);


			TekrarHesapla();
		}

		private void dataGridSecilen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int TiklananID = int.Parse(dataGridSecilen.Rows[e.RowIndex].Cells[0].Value.ToString());

			var iptalEdilen = secilen.Where(x => x.ID == TiklananID).FirstOrDefault();
			sepet.Add(iptalEdilen);
			secilen.Remove(iptalEdilen);

			TekrarHesapla();
		}

		private void TekrarHesapla()
		{
			//-------------LİSTELEME VE HESAPLAMA BÖLÜMÜ------------------

			dataGridViewSiparis.DataSource = new BindingList<SiparisSepet>(sepet);
			dataGridSecilen.DataSource = new BindingList<SiparisSepet>(secilen);

			decimal toplamm = 0;
			foreach (var item in sepet.ToList())
			{
				toplamm += item.Adet * Convert.ToDecimal(item.Fiyat);
			}
			LblOdenmesiGereken.Text = "Ödenmesi Gereken Fiyat : " + toplamm.ToString("N");
			decimal toplam = 0;
			foreach (var item in secilen.ToList())
			{
				toplam += item.Adet * Convert.ToDecimal(item.Fiyat);
			}
			labelSecilenFiyat.Text = "Seçilen Ürünlerin Fiyatı : " + toplam.ToString("N");


		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (var item in sepet.ToList())
			{
				secilen.Add(item);
				sepet.Remove(item);
			}
			TekrarHesapla();
		}

		private void btnMasaIptal_Click(object sender, EventArgs e)
		{
			if (dataGridViewSiparis.Rows.Count > 0)
			{
				using (RestaurantEntities db = new RestaurantEntities())
				{
					foreach (var item in db.TBLBasket.Where(x => x.TableID == MasaNo).ToList())
					{
						db.TBLBasket.Remove(db.TBLBasket.Find(item.ID));
						db.SaveChanges();
					}

					//1.yol masayı false yapma
					//TBLTable t = db.TBLTable.Find(MasaNo);
					//t.Status = false;
					//db.SaveChanges();

					//2.yol
					db.TBLTable.Find(MasaNo).Status = false;
					db.SaveChanges();

					MessageBox.Show("Masa kapatılıyor.");

					FrmMasalar frm = (FrmMasalar)Application.OpenForms["FrmMasalar"];
					if (frm != null)
					{
						frm.doldur();
					}
					this.Hide();
				}

			}
			else
			{
				MessageBox.Show("Masaya Sipariş Girilmemiştir.");
			}
		}

		private void btnOdeme_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (var item in secilen.ToList())
				{
					using (RestaurantEntities db = new RestaurantEntities())
					{
						TBLOrderDetail o = new TBLOrderDetail();
						o.Name = item.Urun;
						if (radioKrediKart.Checked)
						{
							o.Payment = "Kredi Kartı";
						}
						else if (radioNakit.Checked)
						{
							o.Payment = "Nakit Ödeme";
						}

						o.Piece = item.Adet;
						o.Price = Convert.ToDecimal(item.Fiyat);
						o.PaymentDate = DateTime.Now;
						o.UserID = 0;
						db.TBLOrderDetail.Add(o);
						var bulunanPrimary = db.TBLBasket.Where(x => x.ProductID == item.ID && x.TableID == MasaNo).FirstOrDefault();
						db.TBLBasket.Remove(db.TBLBasket.Find(bulunanPrimary.ID));
						db.SaveChanges();

						MessageBox.Show("Ödeme alınmıştır.");
						secilen.Clear();
						TekrarHesapla();

						if (dataGridViewSiparis.Rows.Count == 0)
						{
							db.TBLTable.Where(x => x.ID == MasaNo).FirstOrDefault().Status = false;
							db.SaveChanges();

							FrmMasalar frm = (FrmMasalar)Application.OpenForms["FrmMasalar"];
							if (frm != null)
							{
								frm.doldur();
							}
							this.Hide();
						}

					}
				}
			}
			catch (Exception )
			{
				
			}
			

		}
	}
}

