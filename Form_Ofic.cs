using Ekzamen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class Form_Ofic : Form
    {
        public Form_Ofic()
        {
            InitializeComponent();
        }

        private void Form_Ofic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet4.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.restaurantDataSet4.Orders);
            Model1 model1 = new Model1();
            var data_menu = model1.Menu.ToList();
            dataGridView1.DataSource = data_menu;
        }
    }
}
