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
using MySql.Data.MySqlClient;
namespace NoteCheck
{
    public partial class LoginProfessor : Form
    {
        public string Action { get; set; }

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

        }
        private void LoadFontLouis()
        {
            string fontPath = @"./Louis-George-Cafe-Bold.ttf";
            privateFonts.AddFontFile(fontPath);

            lblCampoNome.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblCampoSenha.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            txtNome.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            txtSenha.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            cbxAno.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            cbxCurso.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnEntrar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnCadastrar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
        }

        public LoginProfessor(string action)
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
            Action = action;
            if (Action == "Retirar")
            {
                cbxAno.Visible = true;
                cbxCurso.Visible = true;
                lblCampoCurso.Visible = true;
            }
        }

        private void LoginProfessor_Load(object sender, EventArgs e)
        {
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));
            lblCampoCurso.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, cbxCurso.Width, cbxCurso.Height, 10, 10));
            lblCampoNome.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, cbxCurso.Width, cbxCurso.Height, 10, 10));
            lblCampoSenha.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, cbxCurso.Width, cbxCurso.Height, 10, 10));
            txtNome.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNome.Width, txtNome.Height, 10, 10));
            txtSenha.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtSenha.Width, txtSenha.Height, 10, 10));
            cbxAno.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, cbxAno.Width, cbxAno.Height, 10, 10));
            cbxCurso.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, cbxCurso.Width, cbxCurso.Height, 10, 10));
            btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnEntrar.Width, btnEntrar.Height, 10, 10));
            btnCadastrar.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnCadastrar.Width, btnCadastrar.Height, 10, 10));


        }

        private void lblAcao_Click(object sender, EventArgs e)
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
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
            using (var connection = new MySqlConnection(Conexao))
            {
                try
                {
                    MySqlCommand query = new MySqlCommand("select id from professor where nome = '" + txtNome.Text + "' and senha = '" + txtSenha.Text + "'", connection);

                    connection.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query);
                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        int professorId = Convert.ToInt32(dataTable.Rows[0]["id"]);
                        MessageBox.Show("Bem vindo professor(a) " + txtNome.Text);
                        switch (Action)
                        {
                            case "Retirar":
                                RetirarNotebooks retirarNotebooks = new RetirarNotebooks(Action, professorId);
                                this.Hide();
                                retirarNotebooks.ShowDialog();
                                this.Dispose();
                                break;
                            case "a":

                                break;
                            default:
                                MessageBox.Show("Login realizado com sucesso, mas infelizmente ocorreu um erro, retorne a página inicial");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome ou senha incorretos.");
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroProfessor cadastroProfessor = new CadastroProfessor(Action);
            this.Hide();
            cadastroProfessor.ShowDialog();
            this.Dispose();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
