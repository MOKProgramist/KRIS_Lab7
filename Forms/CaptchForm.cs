using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KRIS_Lab7.Libs;

namespace KRIS_Lab7.Forms
{
    public partial class CaptchForm : Form
    {
        Captch captch = new Captch();
        public CaptchForm()
        {
            InitializeComponent();
        }

        private void CaptchForm_Load(object sender, EventArgs e)
        {
            CreateCapth();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CreateCapth();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateCapth();
        }

        private void CreateCapth()
        {
            timer1.Stop();

            LabelCaptch.Text = captch.Create();

            timer1.Start();
        }
        private void textBoxCaptch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCaptch.Text == captch.captch)
            {
                Close();
            }
        }
    }
}
