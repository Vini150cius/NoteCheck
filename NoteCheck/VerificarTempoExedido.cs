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
                string data_source = "server=127.0.0.1;port=3306;uid=root;pwd=root;database=noteCheck;";

                conexao = new MySqlConnection(data_source);

                string sql = "CALL sp_notebooks_em_uso_excedendo_tempo();";

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    int contadorAlunos = 0;
                    List<string> informacoesAlunos = new List<string>();

                    while (reader.Read())
                    {
                        int idNotebook = reader.GetInt32("numero_notebook");
                        string nomeAluno = reader.GetString("nome_aluno");
                        int horasPassadas = reader.GetInt32("horas_em_uso");

                        informacoesAlunos.Add($"Notebook ID: {idNotebook}, do aluno: {nomeAluno}, passou {horasPassadas} horas da retirada.");
                        contadorAlunos++;
                    }

                    if (contadorAlunos > 8)
                    {
                        string informacoes = $"Atenção! {contadorAlunos} alunos estão com notebooks por mais de 5 horas";
                        MessageBox.Show(informacoes);
                    }
                    else if (contadorAlunos > 0)
                    {
                        foreach (var info in informacoesAlunos)
                        {
                            MessageForm alerta = new MessageForm(info);
                            alerta.Show();
                        }
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
