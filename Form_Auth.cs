using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ekzamen.Model;

namespace Ekzamen
{
    public partial class Form_Auth : Form
    {
        public Form_Auth()
        {
            InitializeComponent();
            Model1 model = new Model1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            var users = model.Workers.ToList();
            foreach ( var worker in users )
            {
                if (textBox1.Text == worker.Login && textBox2.Text == worker.Password && worker.RoleID == 1)
                {
                    Form_SuPovar form_supovar = new Form_SuPovar();
                    form_supovar.Show();
                }
                if (textBox1.Text == worker.Login && textBox2.Text == worker.Password && worker.RoleID == 2)
                {
                    Form_SuPovar form_supovar = new Form_SuPovar();
                    form_supovar.Show();
                }
                if (textBox1.Text == worker.Login && textBox2.Text == worker.Password && worker.RoleID == 3)
                {
                    Form_Povar form_povar = new Form_Povar();
                    form_povar.Show();
                }
                if (textBox1.Text == worker.Login && textBox2.Text == worker.Password && worker.RoleID == 4)
                {
                    Form_Admin form_admin = new Form_Admin();
                    form_admin.Show();
                }
                if (textBox1.Text == worker.Login && textBox2.Text == worker.Password && worker.RoleID == 6)
                {
                    Form_Ofic form_ofic = new Form_Ofic();
                    form_ofic.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Guest form_guest = new Form_Guest();
            form_guest.Show();
        }
    }
}
