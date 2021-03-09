using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProjeRestaurant.DataBase;

namespace ProjeRestaurant
{
	public partial class UserLogin : Form
	{
		public UserLogin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				if (db.TBLUser.Any(x=>x.Username==txtUser.Text && x.Password==txtPass.Text))
				{
					var userBilgi = db.TBLUser.Where(x => x.Username == txtUser.Text && x.Password == txtPass.Text).FirstOrDefault();

					Properties.Settings.Default.UserYetki = userBilgi.Authority;
					Properties.Settings.Default.Save();
					FrmMasalar masaEkran = new FrmMasalar();
					masaEkran.Show();
					this.Hide();
					
				}
				else
				{
					txtUser.BackColor=Color.Crimson;
					txtUser.ForeColor=Color.AliceBlue;
					txtPass.BackColor=Color.Crimson;
					txtPass.ForeColor=Color.AliceBlue;
					MessageBox.Show("giriş başarısız.");
				}
				
			}
			
		}

		private void UserLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
