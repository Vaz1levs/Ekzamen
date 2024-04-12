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
    public partial class Form_Guest : Form
    {
        public Form_Guest()
        {
            InitializeComponent();
        }

        private void Form_Guest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restaurantDataSet3.Menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.restaurantDataSet3.Menu);

        }
    }
}
