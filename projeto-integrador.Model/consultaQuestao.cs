using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class consultaQuestao
{
    public static Questao ObterQuestao(string enunciado, string alternativaA, string alternativaB, string alternativaC, string alternativaD, string modulo)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Questao questao = null;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Select * from Questoes Where enunciado = @enunciado, alternativaA = @alternativaA, alternativaB = @alternativaB, alternativaC = @alternativaC, alternativaD = @alternativaD, modulo = @modulo";
            comando.Parameters.AddWithValue("@enunciado", enunciado);
            comando.Parameters.AddWithValue("@alternativaA", alternativaA);
            comando.Parameters.AddWithValue("@alternativaB", alternativaB);
            comando.Parameters.AddWithValue("@alternativaC", alternativaC);
            comando.Parameters.AddWithValue("@alternativaD", alternativaD);
            comando.Parameters.AddWithValue("@modulo", modulo);
            var leitura = comando.ExecuteReader();

            while (leitura.Read())
            {
                questao = new Questao();
                questao.id = leitura.GetInt32("id");
                questao.enunciado = leitura.GetString("enunciado");
                questao.alternativaA = leitura.GetString("alternativaA");
                questao.alternativaB = leitura.GetString("alternativaB");
                questao.alternativaC = leitura.GetString("alternativaC");
                questao.alternativaD = leitura.GetString("alternativaD");
                questao.modulo = leitura.GetString("modulo");
                break;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return questao;
    }
}