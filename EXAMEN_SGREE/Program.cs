using System;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new FormLogin())
            {
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK && SessionUtilisateur.EstConnecte)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}