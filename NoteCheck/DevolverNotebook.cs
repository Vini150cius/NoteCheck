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
    public partial class DevolverNotebook: Form
    {
        internal string HoraEntrega {  get; set; }
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

            lblRetirar.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);

        }
        private void LoadFontLouis()
        {
            string fontPath = @"./Louis-George-Cafe-Bold.ttf";
            privateFonts.AddFontFile(fontPath);

            lblCampoNomeAluno.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblNumeroNote.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnVoltar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnDevolver.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
        }

        public DevolverNotebook()
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
        }

        private void DevolverNotebook_Load(object sender, EventArgs e)
        {
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));
            txtNomeAluno.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNomeAluno.Width, txtNomeAluno.Height, 10, 10));
            txtNumeroNote.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNumeroNote.Width, txtNumeroNote.Height, 10, 10));
            btnDevolver.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnDevolver.Width, btnDevolver.Height, 10, 10));
            pnlTimer.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlTimer.Width, pnlTimer.Height, 15, 15));

            Image img = Properties.Resources.seta;
            Image resizedImg = new Bitmap(img, new Size(20, 20));
            btnVoltar.Image = resizedImg;
            HoraEntrega = DateTime.Now.ToString("HH:mm");
        }

        private void tmrTelas_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm");
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

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (txtNomeAluno.Text.Length < 3)
            {
                MessageBox.Show("Nome inválido ou muito pequeno!!", "Campo de nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Int32.Parse(txtNumeroNote.Text) < 0 || Int32.Parse(txtNumeroNote.Text) > 50 || txtNumeroNote.Text.Length < 1)
            {
                MessageBox.Show("Número de notebook inválido!!", "Campo de número de notebook inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Int32.Parse(txtNumeroNote.Text) > 0 && Int32.Parse(txtNumeroNote.Text) <= 50)
                {
                    MySqlConnection Conexao = null;
                    try
                    {
                        string data_source = "datasource=localhost; username=root; database=notecheck";
                        Conexao = new MySqlConnection(data_source);
                        string sqlVerificar = "CALL sp_notebook_verificar(@numeroNotebook);";

                        MySqlCommand comandoVerificar = new MySqlCommand(sqlVerificar, Conexao);
                        comandoVerificar.Parameters.AddWithValue("@numeroNotebook", txtNumeroNote.Text);

                        Conexao.Open();

                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(comandoVerificar);
                        da.Fill(dataTable);

                        DataRow row = dataTable.Rows[0];
                        string status = row["status_notebook"].ToString();

                        if (status == "em uso" || status == "manutenção")
                        {
                            // Consulta para selecionar o id_uso do notebook em uso
                            string sqlSelectId = "CALL sp_notebook_selecionar_id(@nomeAluno, @numeroNotebook)";

                            MySqlCommand comandoSelect = new MySqlCommand(sqlSelectId, Conexao);
                            comandoSelect.Parameters.AddWithValue("@nomeAluno", txtNomeAluno.Text);
                            comandoSelect.Parameters.AddWithValue("@numeroNotebook", txtNumeroNote.Text);

                            DataTable dataTableId = new DataTable();
                            MySqlDataAdapter daId = new MySqlDataAdapter(comandoSelect);
                            daId.Fill(dataTableId);

                            if (dataTableId.Rows.Count > 0)
                            {
                                DataRow rowId = dataTableId.Rows[0];
                                string idUso = rowId["id_uso"].ToString();

                                string sqlDevolver = "CALL sp_notebook_devolver(@nomeAluno, @numeroNotebook, @horaEntrega, @idUso)";

                                MySqlCommand comandoDevolver = new MySqlCommand(sqlDevolver, Conexao);
                                comandoDevolver.Parameters.AddWithValue("@nomeAluno", txtNomeAluno.Text);
                                comandoDevolver.Parameters.AddWithValue("@numeroNotebook", txtNumeroNote.Text);
                                comandoDevolver.Parameters.AddWithValue("@horaEntrega", HoraEntrega);
                                comandoDevolver.Parameters.AddWithValue("@idUso", idUso);

                                comandoDevolver.ExecuteNonQuery();

                                MessageBox.Show("Notebook devolvido com sucesso!!", "Devolução bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Erro na devolução!! Não foi possível localizar o uso desse notebook em seu nome", "Devolução falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (status == "disponível")
                        {
                            MessageBox.Show("Esse notebook já foi devolvido!!", "Devolução falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Erro na devolução!!", "Devolução falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar: " + ex.Message);
                    }
                    finally
                    {
                        if (Conexao.State == ConnectionState.Open)
                        {
                            Conexao.Close();
                            txtNomeAluno.Text = null;
                            txtNumeroNote.Text = null;
                        }
                    }
                }
            }
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
