
namespace ProjetoFatec.br.com.projetofatec.view
{
    partial class frmclientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcadastrodeclientes = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgclientes = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btneditar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPesquisar = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblcadastrodeclientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblcadastrodeclientes
            // 
            this.lblcadastrodeclientes.AutoSize = true;
            this.lblcadastrodeclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastrodeclientes.Location = new System.Drawing.Point(418, 11);
            this.lblcadastrodeclientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcadastrodeclientes.Name = "lblcadastrodeclientes";
            this.lblcadastrodeclientes.Size = new System.Drawing.Size(238, 29);
            this.lblcadastrodeclientes.TabIndex = 0;
            this.lblcadastrodeclientes.Text = "Cadastro de Clientes";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConsultar);
            this.tabPage2.Controls.Add(this.cbPesquisar);
            this.tabPage2.Controls.Add(this.textPesquisa);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dgclientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1246, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas de Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgclientes
            // 
            this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclientes.Location = new System.Drawing.Point(18, 85);
            this.dgclientes.Name = "dgclientes";
            this.dgclientes.Size = new System.Drawing.Size(1185, 242);
            this.dgclientes.TabIndex = 0;
            this.dgclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgclientes_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.cbuf);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnpesquisar);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.lblRG);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1246, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Location = new System.Drawing.Point(992, 255);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(121, 28);
            this.cbuf.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(925, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Estado";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(628, 255);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(266, 26);
            this.txtcidade.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cidade";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(806, 215);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(367, 26);
            this.txtcomplemento.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(750, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Comp.";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(906, 140);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(126, 26);
            this.txtnumero.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(833, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Número";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(592, 135);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(152, 33);
            this.btnpesquisar.TabIndex = 15;
            this.btnpesquisar.Text = "pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(114, 255);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(412, 26);
            this.txtbairro.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Bairro";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(114, 212);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(628, 26);
            this.txtendereco.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Endereço";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(114, 172);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtcelular.Mask = "(##),#####,####";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(252, 26);
            this.txtcelular.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Celular";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(435, 137);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(146, 26);
            this.txtcep.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cep";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(114, 133);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefone.Mask = "(##),####,####";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(252, 26);
            this.txttelefone.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(806, 101);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(367, 26);
            this.txtcpf.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPF";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(114, 97);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(628, 26);
            this.txtemail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(806, 58);
            this.txtrg.Margin = new System.Windows.Forms.Padding(4);
            this.txtrg.Mask = "##,###,###-##";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(367, 26);
            this.txtrg.TabIndex = 6;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(114, 16);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(126, 26);
            this.txtcodigo.TabIndex = 2;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(764, 61);
            this.lblRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(34, 20);
            this.lblRG.TabIndex = 5;
            this.lblRG.Text = "RG";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(114, 54);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(628, 26);
            this.txtnome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(55, 58);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 393);
            this.tabControl1.TabIndex = 1;
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = global::ProjetoFatec.Properties.Resources.Editar3;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(770, 469);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(230, 47);
            this.btneditar.TabIndex = 32;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletar.Image = global::ProjetoFatec.Properties.Resources.Excluir;
            this.btndeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeletar.Location = new System.Drawing.Point(518, 469);
            this.btndeletar.Margin = new System.Windows.Forms.Padding(4);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(230, 47);
            this.btndeletar.TabIndex = 31;
            this.btndeletar.Text = "Excluir";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Image = global::ProjetoFatec.Properties.Resources.Positivo;
            this.btncadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastrar.Location = new System.Drawing.Point(244, 469);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(245, 47);
            this.btncadastrar.TabIndex = 30;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(124, 35);
            this.textPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(162, 22);
            this.textPesquisa.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Pesquisar:";
            // 
            // cbPesquisar
            // 
            this.cbPesquisar.FormattingEnabled = true;
            this.cbPesquisar.Items.AddRange(new object[] {
            "CPF",
            "RG",
            "E-mail"});
            this.cbPesquisar.Location = new System.Drawing.Point(349, 35);
            this.cbPesquisar.Name = "cbPesquisar";
            this.cbPesquisar.Size = new System.Drawing.Size(126, 24);
            this.cbPesquisar.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Location = new System.Drawing.Point(514, 32);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 29);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1278, 555);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcadastrodeclientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.DataGridView dgclientes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbPesquisar;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Label label13;
    }
}