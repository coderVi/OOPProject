using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<Admin> admins = new List<Admin>();
        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin()
            {
                Fiyat = Convert.ToInt32(textBox1.Text),
                Kdv = Convert.ToInt32(textBox2.Text)
            };
            admins.Add(a);
            

            dataGridView1.DataSource = admins;
            HideColumns();
        }
        private void HideColumns()
        {
            
            if (dataGridView1.Columns.Contains("Id"))
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns.Contains("Kadi"))
                dataGridView1.Columns["Kadi"].Visible = false;

            if (dataGridView1.Columns.Contains("Sifre"))
                dataGridView1.Columns["Sifre"].Visible = false;

            if (dataGridView1.Columns.Contains("Rol"))
                dataGridView1.Columns["Rol"].Visible = false;
        }
    }
}
