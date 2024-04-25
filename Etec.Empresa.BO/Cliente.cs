using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;





namespace Etec.Empresa.BO
{
    public class Cliente
    {
       public string Nome  { get; set; }
       public string CPF { get; set; }
       public DateTime DtNascimento{ get; set; }
       public string Rua { get; set; }
       public int Numero { get; set; }

        public void cadastrarCliente(Cliente cliente)
        {
            string conexaoBD = "server=localhost;database=aula;uid=root;pwd=etec";

            MySqlConnection minhaconexao = new MySqlConnection(conexaoBD);
            minhaconexao.Open();
            string comandoSql = "insert into cliente (CPF, Nome, dtNascimento, rua, numero) values('" + cliente.CPF + " ','" + cliente.Nome + "','" + cliente.DtNascimento.ToString("yyyy-MM-dd") + "','" + cliente.Rua + "','" + cliente.Numero + "')";
            MySqlCommand comando = new MySqlCommand(comandoSql, minhaconexao);

            comando.ExecuteNonQuery();
        }
    }
}
