using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCheck
{
    internal class VerificarTempoExedido
    {
        public void VerificarTempo()
        {
            MySqlConnection conexao = null;
            try
            {
                string data_source = "datasource=localhost; username=root; database=notecheck";
                conexao = new MySqlConnection(data_source);

                string sql = "CALL sp_notebooks_tempo_excedido();";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idNotebook = reader.GetInt32("numero_notebook");
                        string nomeAluno = reader.GetString("nome_aluno");
                        int horasPassadas = reader.GetInt32("horas_passadas");

                        string informacoes = $"Notebook ID: {idNotebook}, do aluno: {nomeAluno}, passou {horasPassadas} horas da retirada.";

                        MessageForm alerta = new MessageForm(informacoes);
                        alerta.Show();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }
}
