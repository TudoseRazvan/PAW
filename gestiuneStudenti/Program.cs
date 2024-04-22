using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiuneStudenti
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();  // Inițializează Form1
            FormStudent formStudent = new FormStudent(form1);  // Inițializează FormStudent cu referința către Form1

            form1.Show();  // Afișează Form1
            Application.Run();  // Rulează aplicația
        }
    }
}
