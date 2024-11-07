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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isPasswordVisible = false;
        private void btnSifre_Click(object sender, EventArgs e)
        {
            
            isPasswordVisible = !isPasswordVisible;
            if (isPasswordVisible)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtKadi.Text.Trim().ToLower();
                string password = txtSifre.Text.Trim();
                if (username == "admin" && password == "123456")
                {
                    Form2 frm2 = new Form2();
                    frm2.Show(); this.Hide();
                }
                else
                { 
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Hata " + ex.Message);
            }
            
        }
    }
}
