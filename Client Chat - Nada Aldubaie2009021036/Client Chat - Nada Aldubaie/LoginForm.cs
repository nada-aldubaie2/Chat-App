using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Chat___Nada_Aldubaie
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }
        public String Textb()
        {
            return textBox1.Text;
        }

        public void slblU(String v)
        {
            lblName.Text = v;
        }
        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;

        }
    }
}
