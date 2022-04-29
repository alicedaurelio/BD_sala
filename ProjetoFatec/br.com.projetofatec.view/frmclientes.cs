using ProjetoFatec.br.com.projetofatec.dao;
using ProjetoFatec.br.com.projetofatec.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFatec.br.com.projetofatec.view
{
    public partial class frmclientes : Form
    {
        public frmclientes()
        {
            InitializeComponent();
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            //Carregar o datagridview
            ClienteDAO dao = new ClienteDAO();
            dgclientes.DataSource = dao.listarClientes();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botao cadastrar
            try
            {
                //1°Passo - Receber os dados da tela
                Clientes obj = new Clientes();
                obj.nome        = txtnome.Text;
                obj.email       = txtemail.Text;
                obj.rg          = txtrg.Text;
                obj.cpf         = txtcpf.Text;
                obj.telefone    = txttelefone.Text;
                obj.celular     = txtcelular.Text;
                obj.cep         = txtcep.Text;
                obj.numero      = int.Parse(txtnumero.Text);
                obj.endereco    = txtendereco.Text;
                obj.bairro      = txtbairro.Text;
                obj.complemento = txtcomplemento.Text;
                obj.estado      = cbuf.Text;

                //2 Passo - executar o metodo cadastrarCliente
                ClienteDAO dao = new ClienteDAO();
                dao.cadastrarCliente(obj);

            }
            catch (Exception)
            {

                MessageBox.Show("Digite todos os campos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botao excluir
            try
            {
                //1°Passo - Receber os dados da tela
                Clientes obj = new Clientes();
                obj.codigo = int.Parse(txtcodigo.Text);

                //2 Passo - executar o metodo excluirCliente
                ClienteDAO dao = new ClienteDAO();
                dao.excluirCliente(obj);

                //Recarregar o datagridview
                dgclientes.DataSource = dao.listarClientes();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite todos os campos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada 
            txtcodigo.Text       = dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text         = dgclientes.CurrentRow.Cells[1].Value.ToString();          
            txtrg.Text           = dgclientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text          = dgclientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text        = dgclientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text     = dgclientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text      = dgclientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text          = dgclientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text     = dgclientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text       = dgclientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text  = dgclientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text       = dgclientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text       = dgclientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text            = dgclientes.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber o nome do campo de texto
            string nome = textPesquisa.Text;

            //2 Passo - Criar o objeto ClienteDAO
            ClienteDAO dao = new ClienteDAO();
            dgclientes.DataSource = dao.ConsultaClientePorNome(nome);
        }
    }
}
