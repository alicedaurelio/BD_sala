using MySql.Data.MySqlClient;
using ProjetoFatec.br.com.projetofatec.con;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFatec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao;

                conexao = new ConnectionFactory().getConnection();
                conexao.Open();

                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception erro)            {

                MessageBox.Show("Desconectado! Erro: " + erro);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void txtdatanasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
