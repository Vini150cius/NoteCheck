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
        internal bool Disponibilidade { get; set; }
        internal string NomeProfessor { get; set; }
        internal string DataAtual {  get; set; }
        internal string HoraEntrega { get; set; }

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
            lblRetirar.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
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

                    NomeProfessor = row["nome"].ToString();
                    lblProfessorNome.Text = "Professor: " + NomeProfessor;
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
            txtStatus.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtStatus.Width, txtStatus.Height, 50, 50));
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
            DataAtual = DateTime.Now.ToString("yyyy-MM-dd");
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
            else if (Int32.Parse(txtNumeroNote.Text) < 0 || Int32.Parse(txtNumeroNote.Text) > 50 || txtNumeroNote.Text.Length < 1)
            {
                MessageBox.Show("Número de notebook inválido!!", "Campo de número de notebook inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mtbTempoInicial.Text.Length < 4)
            {
                MessageBox.Show("Hora da retirada inválida!!", "Campo de horario de retirada inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Disponibilidade == false)
            {
                MessageBox.Show("Notebook indisponível, em uso ou em manutenção", "Notebook indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
                using (var connection = new MySqlConnection(Conexao))
                {
                    try
                    {
                        HoraEntrega = mtbTempoFinal.Text.Length < 4 ? "NULL" : "'" + mtbTempoFinal.Text + "'";

                        string query = "INSERT INTO uso_notebook (nome_aluno, turma, professor_responsavel, data_retirada, hora_retirada, hora_entrega, numero_notebook) " +
                                "VALUES ('" + txtNomeAluno.Text + "', '" + Curso + "', '" + NomeProfessor + "', '" + DataAtual + "', '" + mtbTempoInicial.Text + "', " + HoraEntrega + ", " + txtNumeroNote.Text + ")";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();
                        command.ExecuteNonQuery();

                        string updateStatusQuery = "UPDATE notebook SET status_notebook = 'em uso' WHERE numero_notebook = " + txtNumeroNote.Text;
                        MySqlCommand updateCommand = new MySqlCommand(updateStatusQuery, connection);
                        updateCommand.ExecuteNonQuery(); 

                        MessageBox.Show("Notebook retirado com sucesso!!", "Retirada bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        txtNomeAluno.Text = string.Empty;
                        txtNumeroNote.Text = string.Empty;
                        mtbTempoFinal = null;
                        mtbTempoInicial = null;
                        mtbTempoInicial.Text = DateTime.Now.ToString("HH:mm");
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

        private void txtNumeroNote_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(txtNumeroNote.Text) > 0 && Int32.Parse(txtNumeroNote.Text) <= 50)
            {
                string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
                using (var connection = new MySqlConnection(Conexao))
                {
                    try
                    {
                        MySqlCommand query = new MySqlCommand("SELECT status_notebook FROM notebook WHERE numero_notebook = '" + txtNumeroNote.Text + "'", connection);
                        connection.Open();

                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(query);
                        da.Fill(dataTable);

                        DataRow row = dataTable.Rows[0];

                        string status = row["status_notebook"].ToString();
                        if (status == "disponível")
                        {
                            txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(206)))), ((int)(((byte)(164)))));
                            Disponibilidade = true;
                        }
                        else if (status == "em uso")
                        {
                            txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(21)))), ((int)(((byte)(81)))));
                            Disponibilidade = false;
                        }
                        else if (status == "manutenção")
                        {
                            txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(193)))), ((int)(((byte)(53)))));
                            Disponibilidade = false;
                        }
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
            else {
                txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            }
        }
    }
}
