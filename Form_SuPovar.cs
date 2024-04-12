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
    public partial class Form_SuPovar : Form
    {
        public Form_SuPovar()
        {
            InitializeComponent();
        }

        private void Form_SuPovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet8.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.restaurantDataSet8.Menu);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet7.OrderDish". При необходимости она может быть перемещена или удалена.
            this.orderDishTableAdapter.Fill(this.restaurantDataSet7.OrderDish);
            Model1 model1 = new Model1();
            var data_menu = model1.Menu.ToList();
            dataGridView1.DataSource = data_menu;
            Model1 model2 = new Model1();
            var data_order = model1.OrderDish.ToList();
            dataGridView1.DataSource = data_order;
        }
    }
}
