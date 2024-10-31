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

            lblLogo.Font = new Font(privateFonts.Families[0], 20, FontStyle.Regular);
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

                            if (status == "em uso" || status == "manutenção")
                            {
                                // Consulta para selecionar o id_uso do notebook em uso
                                string selectIdQuery = "SELECT u.id_uso FROM uso_notebook u JOIN notebook n ON u.numero_notebook = n.numero_notebook WHERE u.nome_aluno = '" + txtNomeAluno.Text + "' AND n.numero_notebook = " + txtNumeroNote.Text + " AND n.status_notebook = 'em uso'";
                                MySqlCommand selectIdCommand = new MySqlCommand(selectIdQuery, connection);

                                DataTable dataTableId = new DataTable();
                                MySqlDataAdapter daId = new MySqlDataAdapter(selectIdCommand);
                                daId.Fill(dataTableId);

                                if (dataTableId.Rows.Count > 0)
                                {
                                    DataRow rowId = dataTableId.Rows[0];
                                    string idUso = rowId["id_uso"].ToString();

                                    string updateStatusQuery = "UPDATE notebook SET status_notebook = 'disponível' WHERE numero_notebook = " + txtNumeroNote.Text;
                                    MySqlCommand updateCommand = new MySqlCommand(updateStatusQuery, connection);
                                    updateCommand.ExecuteNonQuery();

                                    string updateUsoQuery = "UPDATE uso_notebook SET hora_entrega = '" + HoraEntrega + "' WHERE id_uso = " + idUso;
                                    MySqlCommand updateUsoCommand = new MySqlCommand(updateUsoQuery, connection);
                                    updateUsoCommand.ExecuteNonQuery();

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
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
