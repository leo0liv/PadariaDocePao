using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; // Essencial para falar com o SQL
using System.Configuration;

namespace PadariaDocePao
{
    
    internal class ConexaoBD
    {
        // Pega a string lá do App.config que configuramos antes
        public static string StringConexao = ConfigurationManager.ConnectionStrings["PadariaDocePao.Properties.Settings.PadariaDocePaoConnectionString"].ConnectionString;

        public static SqlConnection ObterConexao()
        {
            return new SqlConnection(StringConexao);
        }
        private void BaixarEstoque(int idProduto, int quantidadeProduzida, SqlConnection con, SqlTransaction transacao)
        {
            // 1. Busca a receita do produto (quais ingredientes e quanto usa de cada)
            string sqlReceita = "SELECT Id_MateriaPrima, Quantidade FROM FichaTecnica WHERE Id_Produto = @idProduto";
            SqlCommand cmdReceita = new SqlCommand(sqlReceita, con, transacao);
            cmdReceita.Parameters.AddWithValue("@idProduto", idProduto);

            using (SqlDataReader leitor = cmdReceita.ExecuteReader())
            {
                while (leitor.Read())
                {
                    int idMateriaPrima = Convert.ToInt32(leitor["Id_MateriaPrima"]);
                    decimal qtdNaReceita = Convert.ToDecimal(leitor["Quantidade"]);

                    // Calcula o total a descontar (Qtd na receita * Qtd de bolos feitos)
                    decimal totalDescontar = qtdNaReceita * quantidadeProduzida;

                    // 2. Atualiza o estoque da matéria-prima
                    // NOTA: Precisamos de um segundo comando aqui dentro, mas o DataReader está aberto.
                    // O ideal é carregar os dados da receita na memória primeiro ou usar MARS (MultipleActiveResultSets),
                    // mas para simplificar, vamos fazer um comando UPDATE direto após ler tudo ou fechar o leitor temporariamente.
                    // UMA FORMA MAIS SIMPLES E SEGURA (sem conflito de leitor):
                    // Executar o UPDATE diretamente sem ler para a memória do C#:
                }
            }

            // VERSÃO OTIMIZADA DO LOOP ACIMA (Substitui o while inteiro):
            // Este comando SQL faz tudo de uma vez: para cada ingrediente da receita deste produto, desconta do estoque.
            string sqlBaixa = @"
        UPDATE MateriaPrima
        SET EstoqueAtual = EstoqueAtual - (ft.Quantidade * @qtdProduzida)
        FROM MateriaPrima mp
        INNER JOIN FichaTecnica ft ON mp.Id = ft.Id_MateriaPrima
        WHERE ft.Id_Produto = @idProduto";

            SqlCommand cmdBaixa = new SqlCommand(sqlBaixa, con, transacao);
            cmdBaixa.Parameters.AddWithValue("@idProduto", idProduto);
            cmdBaixa.Parameters.AddWithValue("@qtdProduzida", quantidadeProduzida);
            cmdBaixa.ExecuteNonQuery();
        }
    }
}
