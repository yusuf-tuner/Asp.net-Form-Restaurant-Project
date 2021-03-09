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
	public partial class FrmOdenenSiparis : Form
	{
		public FrmOdenenSiparis()
		{
			InitializeComponent();
		}

		private void FrmOdenenSiparis_Load(object sender, EventArgs e)
		{
			using (RestaurantEntities db=new RestaurantEntities())
			{
				dataGridView1.DataSource = db.TBLOrderDetail.ToList();
			}
		}
	}
}
