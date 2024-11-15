using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    public partial class StatusNotebook : Form
    {
                
        MySqlConnection Conexao = null;
        public void listaGrid()
        {
            string data_source = "datasource=localhost; username=root; database=notecheck";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "SELECT * FROM notebook;";

            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);

            Conexao.Open();

            try
            {
                DataTable dtLista = new DataTable();
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando);
                objAdp.Fill(dtLista);

                dgDados.DataSource = dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

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

            btnVoltar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
        }

        public StatusNotebook()
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
        }

        private void pnlControles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StatusNotebook_Load(object sender, EventArgs e)
        {
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));

            pnlTimer.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlTimer.Width, pnlTimer.Height, 15, 15));

            Image img = Properties.Resources.seta;
            Image resizedImg = new Bitmap(img, new Size(20, 20));
            btnVoltar.Image = resizedImg;
            listaGrid();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void tmrTelas_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm");
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
