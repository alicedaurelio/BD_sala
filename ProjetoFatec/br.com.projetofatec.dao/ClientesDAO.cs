using MySql.Data.MySqlClient;
using ProjetoFatec.br.com.projetofatec.con;
using ProjetoFatec.br.com.projetofatec.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFatec.br.com.projetofatec.dao
{
    class ClientesDAO
    {
        // Conexao com o banco de dados

        private MySqlConnection conexao;

        public ClientesDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

m
        #region Método Cadastrar Cliente 

        // Metodos cadastrar cliente

        public void CadastrarCliente(Clientes obj)
        {

            try
            {
                // 1 passo - Definir o comando sql - insert into
                string sql = @"insert into tb_clientes () values ()";

            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion 



    }
}
