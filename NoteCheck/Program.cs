using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Timer timer = new Timer();
            timer.Interval = 60000;
            VerificarTempoExedido ClassVerificarTempo = new VerificarTempoExedido();
            timer.Tick += (sender, e) => ClassVerificarTempo.VerificarTempo();
            timer.Start();

            Application.Run(new StartScreen());
        }

        
    }
}
