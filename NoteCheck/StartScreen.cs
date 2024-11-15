using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    public partial class StartScreen : Form
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void LoadFontBebas()
        {
            string fontPath = @"./Bebas-Regular.ttf";
            privateFonts.AddFontFile(fontPath);

            lblBoasVindas.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);

        }
        private void LoadFontLouis()
        {
            string fontPath = @"./Louis-George-Cafe-Bold.ttf";
            privateFonts.AddFontFile(fontPath);

            btnRetirar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnEntregar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnStatus.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnHistorico.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
        }

        public StartScreen()
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();

        }
        private void StartScreen_Load(object sender, EventArgs e)
        {
            btnRetirar.Region = Region.FromHrgn(CreateRoundRectRgn
                (0,0,btnRetirar.Width,btnRetirar.Height, 40, 40));
            btnEntregar.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnEntregar.Width, btnEntregar.Height, 40, 40));
            btnStatus.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnStatus.Width, btnStatus.Height, 40, 40));
            btnHistorico.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnHistorico.Width, btnHistorico.Height, 40, 40));
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));
        }

        private void pnlBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProgram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            string action = "Retirar";
            LoginProfessor login = new LoginProfessor(action);
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            DevolverNotebook devolverNotebook = new DevolverNotebook();
            this.Hide();
            devolverNotebook.ShowDialog();
            this.Dispose();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            StatusNotebook statusNotebook = new StatusNotebook();
            this.Hide();
            statusNotebook.ShowDialog();
            this.Dispose();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            string action = "Historico";
            LoginProfessor login = new LoginProfessor(action);
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }
    }
}
