using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int i = 0;
        List<USER> list = new List<USER>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text) &&
                    !string.IsNullOrEmpty(textBox2.Text) &&
                    comboBox1.SelectedItem != null)
                {
                    USER u = new USER();
                    u.Id = i;
                    u.Kadi = textBox1.Text;
                    u.Sifre = textBox2.Text;
                    u.Rol = comboBox1.SelectedItem.ToString();
                    i++;
                    list.Add(u);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Tüm Alanlar Doldurulmalı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var matchingUser = list.FirstOrDefault(u =>
                    u.Kadi == textBox1.Text &&
                    u.Sifre == textBox2.Text &&
                    u.Rol == "Admin");

                if (matchingUser != null)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş bilgileri hatalı veya kullanıcı 'Admin' değil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
