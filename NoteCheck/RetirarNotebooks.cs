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
    public partial class RetirarNotebooks : Form
    {
        public string Action { get; set; }
        public int ProfessorId { get; set; }
        public string Curso { get; set; }
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

            lblLogo.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            lblBoasVindas.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
            lblProfessorNome.Font = new Font(privateFonts.Families[0], 15, FontStyle.Regular);
            lblCurso.Font = new Font(privateFonts.Families[0], 15, FontStyle.Regular);

        }
        private void LoadFontLouis()
        {
            string fontPath = @"./Louis-George-Cafe-Bold.ttf";
            privateFonts.AddFontFile(fontPath);

            lblCampoNomeAluno.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblNumeroNote.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblTempoUso.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnPronto.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnVoltar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblAte.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
        }

        public RetirarNotebooks(string action, int professorId, string curso)
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
            Action = action;
            ProfessorId = professorId;
            Curso = curso;
        }

        private void RetirarNotebooks_Load(object sender, EventArgs e)
        {
            string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
            using (var connection = new MySqlConnection(Conexao))
            {
                try
                {
                    MySqlCommand query = new MySqlCommand("select * from professor where id = '" + ProfessorId + "'", connection);

                    connection.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query);
                    da.Fill(dataTable);

                    DataRow row = dataTable.Rows[0];

                    string nome = row["nome"].ToString();
                    lblProfessorNome.Text = "Professor: " + nome;
                    lblCurso.Text = Curso;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));
            txtNomeAluno.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNomeAluno.Width, txtNomeAluno.Height, 10, 10));
            txtNumeroNote.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNumeroNote.Width, txtNumeroNote.Height, 10, 10));
            mtbTempoFinal.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, mtbTempoFinal.Width, mtbTempoFinal.Height, 10, 10));
            mtbTempoInicial.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, mtbTempoInicial.Width, mtbTempoInicial.Height, 10, 10));
            btnPronto.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnPronto.Width, btnPronto.Height, 10, 10));
            pnlTimer.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlTimer.Width, pnlTimer.Height, 15, 15));

            Image img = Properties.Resources.seta;
            Image resizedImg = new Bitmap(img, new Size(20, 20));
            btnVoltar.Image = resizedImg;
            mtbTempoInicial.Text = DateTime.Now.ToString("HH:mm");
        }

        private void pnlProgram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text.Length < 3)
            {
                MessageBox.Show("Nome inválido ou muito pequeno!!", "Campo de nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Int32.Parse(txtNumeroNote.Text) < 0 || Int32.Parse(txtNumeroNote.Text) > 100 || txtNumeroNote.Text.Length < 1)
            {
                MessageBox.Show("Número de notebook inválido!!", "Campo de número de notebook inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtbTempoInicial.Text.Length < 4)
            {
                MessageBox.Show("Hora da retirada inválida!!", "Campo de horario de retirada inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
                using (var connection = new MySqlConnection(Conexao))
                {
                    try
                    {
                        MySqlCommand query = new MySqlCommand("INSERT INTO notebooks () VALUES ('" + txtNomeAluno.Text + "','" + txtNumeroNote.Text + "')", connection);

                        connection.Open();
                        MessageBox.Show("Notebook retirado com sucesso!!", "Retirada bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
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
            LoginProfessor loginProfessor = new LoginProfessor(Action);
            this.Hide();
            loginProfessor.ShowDialog();
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrTelas_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
