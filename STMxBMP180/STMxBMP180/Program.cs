using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMxBMP180
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1("DUONG", "123", true));
            /*
            using (var login = new loginform())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    if (login.isUser == true)
                    {
                        Application.Run(new Form1(login.username, login.password, login.isUser));
                    }
                    else
                    {
                        Application.Run(new Form1("", "", login.isUser));
                    }
                }
            }
            */
        }
    }
}
