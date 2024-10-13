using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    public partial class StartScreen : Form
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        public StartScreen()
        {
            InitializeComponent();
            LoadFontTitle();
            LoadFontText();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadFontTitle()
        {
            // Carregar a fonte .ttf do arquivo para a memória
            string fontPath = @"./Bebas-Regular.ttf"; // caminho para o arquivo .ttf
            privateFonts.AddFontFile(fontPath);

            // Atribuir a fonte a um controle, por exemplo, um Label
            lblBemVindo.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
        }
        private void LoadFontText()
        {
            // Carregar a fonte .ttf do arquivo para a memória
            string fontPath = @"./Louis-George-Cafe-Bold.ttf"; // caminho para o arquivo .ttf
            privateFonts.AddFontFile(fontPath);

            // Atribuir a fonte a um controle, por exemplo, um Label
            btnFechar.Font = new Font(privateFonts.Families[1], 16, FontStyle.Bold);
            btnMini.Font = new Font(privateFonts.Families[1], 16, FontStyle.Bold);

        }
    }
}
