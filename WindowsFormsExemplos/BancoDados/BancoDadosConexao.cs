using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExemplos.BancoDados
{
    internal class BancoDadosConexao
    {
        public SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luiz Fernando\Desktop\programacao\C#\proway-curso-c-sharp\WindowsFormsExemplos\BancoDados\WindowsFormsBancoDados.mdf"";Integrated Security=True";
            conexao.Open();

            var comando = conexao.CreateCommand();
            return comando;
        }
    }
}
