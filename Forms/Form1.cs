using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KRIS_Lab7.Forms;
using KRIS_Lab7.Models;

namespace KRIS_Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ModelEF models = new ModelEF();

            Users FindUser = models.Users.FirstOrDefault(user => user.Login == textBoxLogin.Text && user.Password == textBoxPassword.Text);
            if (FindUser != null)
            {
                MessageBox.Show("Пользователь найден");
                return;
            }

            MessageBox.Show("Пользователь не найден, пройдите капчу.");
            CaptchForm captchForm = new CaptchForm();

            captchForm.ShowDialog();
        }
    }
}
