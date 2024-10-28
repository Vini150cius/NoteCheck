using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class CadastroProfessor : Form
    {
        public string Action { get; set; }

        public int passwordMaster { get; set; } = 2811;


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

            lblCampoSenhaMestre.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblCampoNome.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblCampoSenha.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            lblCampoSenhaConfirm.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            txtSenhaMestre.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            txtNome.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            txtSenha.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            txtSenhaConfirm.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
            btnCadastrar.Font = new Font(privateFonts.Families[1], 12, FontStyle.Bold);
        }
        public CadastroProfessor(string action)
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
            Action = action;
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));
            txtSenhaMestre.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtSenhaMestre.Width, txtSenhaMestre.Height, 10, 10));
            txtNome.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNome.Width, txtNome.Height, 10, 10));
            txtSenha.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtSenha.Width, txtSenha.Height, 10, 10));
            txtSenhaConfirm.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtSenhaConfirm.Width, txtSenhaConfirm.Height, 10, 10));
            btnCadastrar.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnCadastrar.Width, btnCadastrar.Height, 10, 10));

            Image img = Properties.Resources.seta;
            Image resizedImg = new Bitmap(img, new Size(20, 20));
            btnVoltar.Image = resizedImg;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtSenhaConfirm.Text == txtSenha.Text)
            {
                if(int.Parse(txtSenhaMestre.Text) == passwordMaster)
                {
                    string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
                    using (var connection = new MySqlConnection(Conexao))
                    {

                        MySqlCommand query = new MySqlCommand("INSERT INTO professor (nome, senha) VALUES ('" + txtNome.Text + "','" + txtSenha.Text + "')", connection);
                        connection.Open();

                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(query);
                        da.Fill(dataTable);
                        connection.Close();
                        MessageBox.Show("Usuário criado com sucesso, já pode realizar o login na tela anterior.", "Cadastro bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginProfessor loginProfessor = new LoginProfessor(Action);
                        this.Hide();
                        loginProfessor.ShowDialog();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("A senha mestre está errada, você não tem permissão para criar um novo usuário.", "Sem permissão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A senha e a confirmação de senha não coincidem. Por favor, tente novamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginProfessor loginProfessor = new LoginProfessor(Action);
            this.Hide();
            loginProfessor.ShowDialog();
            this.Dispose();
        }

        private void pnlProgram_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
