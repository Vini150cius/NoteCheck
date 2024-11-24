using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    public partial class MessageForm : Form
    {
        private int toastX, toastY;
        private int y = 100;
        private string InformacoesDoAlerta { get; set; }
        private static int VerticalOffset = 0; 

        public MessageForm(string informacoesDoAlerta)
        {
            InitializeComponent();
            InformacoesDoAlerta = informacoesDoAlerta;
        }

        private void MessageHide_Tick(object sender, EventArgs e)
        {
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height - 10 - VerticalOffset;

            this.Location = new Point(toastX, toastY);
            lblMessage.Text = InformacoesDoAlerta;

            VerticalOffset += this.Height + 5;
        }

    }
}
