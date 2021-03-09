using System;
using System.Linq;
using System.Windows.Forms;
using ProjeRestaurant.DataBase;
namespace ProjeRestaurant
{
	public partial class FrmNotlar : Form
	{
		
		TBLNote note=new TBLNote();

		private int dataID = 0; // her metod dan erişim sağlanması için tanımlıyoruz.

		public FrmNotlar()
		{
			InitializeComponent();
		}

		private void notesUpdate()
		{   // notlarımın varsa ekrana gelmesini istiyorum.
			RestaurantEntities dbEntities = new RestaurantEntities();

			dataGridNotesView.Rows.Clear();
			dataGridNotesView.ColumnCount = 4;
			dataGridNotesView.Columns[0].Name = "ID";
			dataGridNotesView.Columns[1].Name = "Not";
			dataGridNotesView.Columns[2].Name = "OluşturulmaTarihi";
			dataGridNotesView.Columns[3].Name = "Oluşturan";
			//yukarıda alan isimlerini türkçeleştirdim.

			foreach (var tblNote in dbEntities.TBLNote.ToList())
			{
				string[] satirlar=new string[] {tblNote.ID.ToString(), tblNote.Notes,tblNote.DateTime.ToString(), tblNote.UserID.ToString()};
				dataGridNotesView.Rows.Add(satirlar);
			}
		}

		private void FrmNotlar_Load(object sender, EventArgs e)
		{ 
			notesUpdate();
		}
		private void btnAddNote_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities dbEntities = new RestaurantEntities())
			{
				note.DateTime = DateTime.Now;
				note.Notes = textNote.Text;
				note.UserID = 0;
				dbEntities.TBLNote.Add(note);
				dbEntities.SaveChanges();
				MessageBox.Show("Kayıt Başarılı.");
				notesUpdate();
			}

			
		}
		private void btnUpdateNote_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities dbEntities = new RestaurantEntities())
			{
				if (dataID!=0)
				{
					TBLNote istenilenNote = dbEntities.TBLNote.Find(dataID);
					istenilenNote.Notes = textNote.Text; // istenilen not değitirilip kaydediliyor.
					dbEntities.SaveChanges();
					MessageBox.Show("İşlem başarılı.");
					textNote.Text = "";
				}
				else
				{
					MessageBox.Show("Veri Seçmediniz");
				}
			}

			notesUpdate();
		}

		private void btnDeleteNote_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities dbEntities = new RestaurantEntities())
			{
				// silinmesini istediğimiz satır veritabanından alınıyor ıd ye göre
				if (dataID!=0)
				{
					TBLNote deleteNote = dbEntities.TBLNote.Find(dataID);
					dbEntities.TBLNote.Remove(deleteNote); // silme yapılıyor.
					dbEntities.SaveChanges();				// kayıt ediliyor.
					dataID = 0; // id tekrardan sıfırlanıyor çünkü silinen veriyi tekrar silenemeyeceği için sıfır eşitliyoruz.
					textNote.Text = null;
					MessageBox.Show("işlem başarılı.");
				}
				else
				{
					MessageBox.Show("Not seçimi yapınız.");
				}
				
			}
			notesUpdate();
		}

		private void dataGridNotesView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{	// sütun veya satıra çift tıklanınca verilerim gelsin.
			// cels[1] diyerek grid içinde gelen 1. sütun bilgilerini getiriyoruz.
			textNote.Text = dataGridNotesView.Rows[e.RowIndex].Cells[1].Value.ToString();
			dataID = int.Parse(dataGridNotesView.Rows[e.RowIndex].Cells[0].Value.ToString());

		}
	}
}
