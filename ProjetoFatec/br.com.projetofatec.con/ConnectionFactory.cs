
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ProjetoFatec.br.com.projetofatec.con
{
   public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.
                                ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
