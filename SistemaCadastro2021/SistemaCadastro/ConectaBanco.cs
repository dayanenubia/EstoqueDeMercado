using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaCadastro
{
    class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=estoque");
        public string mensagem;

    //----------------------------------------
        public DataTable listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("lista_produtos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        } // fim do lista_produto

        public bool insereProduto(Produto b)
        {
            MySqlCommand cmd = new MySqlCommand("inserir_produtos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", b.Nome);
            cmd.Parameters.AddWithValue("quantEstoque", b.QuantEstoque);
            cmd.Parameters.AddWithValue("marca", b.Marca);
            cmd.Parameters.AddWithValue("secao", b.Secao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereProduto

        public bool deletaProduto(int codP)
        {
            MySqlCommand cmd = new MySqlCommand("deleta_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codP", codP);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaProduto

        public bool alteraProduto(Produto b, int codP)
        {
            MySqlCommand cmd = new MySqlCommand("altera_produto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codP", codP);
            cmd.Parameters.AddWithValue("nome", b.Nome);
            cmd.Parameters.AddWithValue("quantEstoque", b.QuantEstoque);
            cmd.Parameters.AddWithValue("marca", b.Marca);
            cmd.Parameters.AddWithValue("secao", b.Secao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim alteraBanda
    }
}
