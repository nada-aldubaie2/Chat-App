using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Chat___Nada_Aldubaie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// //Nada Aldubaie *_*

        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm fLogin = new LoginForm();
            Boolean flag = true;

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                if (fLogin.Textb() != "")
                {
                    flag = false;
                    MainForm form = new MainForm();
                    form.setName(fLogin.Textb());
                    Application.Run(form);
                }
                else
                {
                    fLogin.slblU("Please enter");
                    //MessageBox.Show("Please enter");
                }
            }
            else
            {
                Application.Exit();

            }
        }
    }
}
