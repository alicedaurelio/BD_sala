using MySql.Data.MySqlClient;
using ProjetoFatec.br.com.projetofatec.con;
using ProjetoFatec.br.com.projetofatec.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFatec.br.com.projetofatec.dao
{
    public class ClienteDAO
    {

        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Método Que lista todos os clientes
        public DataTable listarClientes()
        {
            try
            {
                //1 Passo - Criar o DataTable e o comando sql
                DataTable tabelacliente = new DataTable();
                string sql = "select * from tb_clientes";

                //2 Passo Organizar e executar o comando sql
                //2 passo - Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
             
                //3 Passo - executar o coando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();


                //4 passo - Criar o MySQLDataApter para 
                //preencher os dados no DataTable;
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelacliente);

                //Fechar a conexao
                conexao.Close();

                return tabelacliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
            }
        }
        #endregion

        #region CadastrarCliente
        public void cadastrarCliente(Clientes obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade, estado)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco,@numero, @complemento, @bairro, @cidade, @estado) ";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);

                executacmd.Parameters.AddWithValue("@cep", obj.cep);

                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                //Fechar a conexao
                conexao.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }
        #endregion

        #region AlterarCliente
        public void alterarCliente(Clientes obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,
                              endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                              where id=@id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com sucesso!");

                //Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region ExcluirCliente

        public void excluirCliente(Clientes obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"delete from tb_clientes where id = @id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);


                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com sucesso!");

                //Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion


        #region Método que consulta Clientes por Nome
            
            public DataTable ConsultaClientePorNome(string nome)
            {
                 try
                 {
                    //1 Passo - Criar o DataTable
                    DataTable tabelaCliente = new DataTable();

                    //2 Passo - Criar o comando sql
                    string sql = @"select * from tb_clientes where nome = @nome";

                    //3 Passo - Organizar e executar o comando sql
                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                    adapter.Fill(tabelaCliente);

                    return tabelaCliente;
                 }
                 catch (Exception erro)
                 {
                    MessageBox.Show("Aconteceu o erro: " + erro);
                    return null;

                    throw;
                 }
            }





        #endregion

    }
}
