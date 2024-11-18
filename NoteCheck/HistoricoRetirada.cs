using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    public partial class HistoricoRetirada : Form
    {

        MySqlConnection Conexao = null;
        public string dataSelecionada {  get; set; }
        public void listaGrid()
        {
            string data_source = "datasource=localhost; username=root; database=notecheck";
            Conexao = new MySqlConnection(data_source);
            string strSQL = "CALL sp_historico_listar(@dataRetirada);";
            MySqlCommand comando = new MySqlCommand(strSQL, Conexao);
            comando.Parameters.AddWithValue("@dataRetirada", dataSelecionada);



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
        public HistoricoRetirada()
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
        }

        private void HistoricoRetirada_Load(object sender, EventArgs e)
        {
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));

            pnlTimer.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlTimer.Width, pnlTimer.Height, 15, 15));

            Image img = Properties.Resources.seta;
            Image resizedImg = new Bitmap(img, new Size(20, 20));
            btnVoltar.Image = resizedImg;
            listaGrid();
            txtNomeAluno.Text = "Nome do aluno";
            txtNumeroNote.Text = "Numero do notebook";
            txtNomeAluno.ForeColor = Color.LightGray;
            txtNumeroNote.ForeColor = Color.LightGray;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpDataDesejada_ValueChanged(object sender, EventArgs e)
        {
            dataSelecionada = dtpDataDesejada.Value.ToString("yyyy-MM-dd");
            listaGrid();
        }

        private void txtNomeAluno_Enter(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text =="Nome do aluno")
            {
                txtNomeAluno.Text = "";
                txtNomeAluno.ForeColor = Color.Black;
            }
        }

        private void txtNomeAluno_Leave(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text == "")
            {
                txtNomeAluno.Text = "Nome do aluno";
                txtNomeAluno.ForeColor = Color.LightGray;
            }
        }

        private void txtNumeroNote_Enter(object sender, EventArgs e)
        {
            if (txtNumeroNote.Text == "Numero do notebook")
            {
                txtNumeroNote.Text = "";
                txtNumeroNote.ForeColor = Color.Black;
            }

        }

        private void txtNumeroNote_Leave(object sender, EventArgs e)
        {
            if (txtNumeroNote.Text == "")
            {
                txtNumeroNote.Text = "Numero do notebook";
                txtNumeroNote.ForeColor = Color.LightGray;
            }
        }
    }
}
