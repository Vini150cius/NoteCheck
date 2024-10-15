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
using MySql.Data;
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
        }

        public LoginProfessor(string action)
        {
            InitializeComponent();
            LoadFontBebas();
            LoadFontLouis();
            Action = action;
            lblAcao.Text = action;
        }

        private void LoginProfessor_Load(object sender, EventArgs e)
        {
            pnlProgram.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, pnlProgram.Width, pnlProgram.Height, 40, 40));
            txtNome.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtNome.Width, txtNome.Height, 10, 10));
            txtSenha.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, txtSenha.Width, txtSenha.Height, 10, 10));

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
        private void button1_Click(object sender, EventArgs e)
        {
            string Conexao = "server=127.0.0.1;port=3306;database=notecheck;user=root;";
            using (var connection = new MySqlConnection(Conexao))
            {
                try
                {
                    MySqlCommand query = new MySqlCommand("select count(*) from professor where nome = '" + txtNome.Text + "' and senha = '" + txtSenha.Text + "'", connection);

                    connection.Open();

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query);
                    da.Fill(dataTable);

                    foreach (DataRow list in dataTable.Rows)
                    {
                        if (Convert.ToInt32(list.ItemArray[0]) > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nome ou senha incorretos.");
                        }
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

        private void imgLogo_Click(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Hide();
            startScreen.ShowDialog();
            this.Dispose();
        }
    }
}
