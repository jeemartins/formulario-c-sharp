namespace Formulario
{
    partial class Form1
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
            this.lblCadastro = new System.Windows.Forms.Label();
            this.grpDadosPessoais = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblTelR = new System.Windows.Forms.Label();
            this.txtTelRes = new System.Windows.Forms.TextBox();
            this.lblTelC = new System.Windows.Forms.Label();
            this.txtTelCel = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdFem = new System.Windows.Forms.RadioButton();
            this.rdMasc = new System.Windows.Forms.RadioButton();
            this.rdNaoIden = new System.Windows.Forms.RadioButton();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpEndereco = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.gpDadosExtras = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkFacebook = new System.Windows.Forms.CheckBox();
            this.chkTwitter = new System.Windows.Forms.CheckBox();
            this.chkInstagram = new System.Windows.Forms.CheckBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.grpDadosPessoais.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.grpEndereco.SuspendLayout();
            this.gpDadosExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(322, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(385, 76);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro Cliente";
            // 
            // grpDadosPessoais
            // 
            this.grpDadosPessoais.Controls.Add(this.btnOcultar);
            this.grpDadosPessoais.Controls.Add(this.btnLimpar);
            this.grpDadosPessoais.Controls.Add(this.btnCarregar);
            this.grpDadosPessoais.Controls.Add(this.pcbFoto);
            this.grpDadosPessoais.Controls.Add(this.grpSexo);
            this.grpDadosPessoais.Controls.Add(this.txtCPF);
            this.grpDadosPessoais.Controls.Add(this.lblCPF);
            this.grpDadosPessoais.Controls.Add(this.txtTelCel);
            this.grpDadosPessoais.Controls.Add(this.lblTelC);
            this.grpDadosPessoais.Controls.Add(this.txtTelRes);
            this.grpDadosPessoais.Controls.Add(this.lblTelR);
            this.grpDadosPessoais.Controls.Add(this.txtRG);
            this.grpDadosPessoais.Controls.Add(this.lblRG);
            this.grpDadosPessoais.Controls.Add(this.txtNome);
            this.grpDadosPessoais.Controls.Add(this.txtCodigo);
            this.grpDadosPessoais.Controls.Add(this.lblNome);
            this.grpDadosPessoais.Controls.Add(this.lblCodigo);
            this.grpDadosPessoais.Location = new System.Drawing.Point(12, 115);
            this.grpDadosPessoais.Name = "grpDadosPessoais";
            this.grpDadosPessoais.Size = new System.Drawing.Size(995, 312);
            this.grpDadosPessoais.TabIndex = 1;
            this.grpDadosPessoais.TabStop = false;
            this.grpDadosPessoais.Text = "Dados Pessoais";
            this.grpDadosPessoais.Enter += new System.EventHandler(this.grpDadosPessoais_Enter);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(212, 26);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(546, 26);
            this.txtNome.TabIndex = 3;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(24, 94);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(46, 20);
            this.lblRG.TabIndex = 4;
            this.lblRG.Text = "R.G.:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(77, 91);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(234, 26);
            this.txtRG.TabIndex = 5;
            // 
            // lblTelR
            // 
            this.lblTelR.AutoSize = true;
            this.lblTelR.Location = new System.Drawing.Point(8, 130);
            this.lblTelR.Name = "lblTelR";
            this.lblTelR.Size = new System.Drawing.Size(124, 20);
            this.lblTelR.TabIndex = 6;
            this.lblTelR.Text = "Tel. Residencial:";
            // 
            // txtTelRes
            // 
            this.txtTelRes.Location = new System.Drawing.Point(139, 130);
            this.txtTelRes.Name = "txtTelRes";
            this.txtTelRes.Size = new System.Drawing.Size(172, 26);
            this.txtTelRes.TabIndex = 7;
            // 
            // lblTelC
            // 
            this.lblTelC.AutoSize = true;
            this.lblTelC.Location = new System.Drawing.Point(317, 133);
            this.lblTelC.Name = "lblTelC";
            this.lblTelC.Size = new System.Drawing.Size(91, 20);
            this.lblTelC.TabIndex = 8;
            this.lblTelC.Text = "Tel. Celular:";
            // 
            // txtTelCel
            // 
            this.txtTelCel.Location = new System.Drawing.Point(414, 130);
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.Size = new System.Drawing.Size(209, 26);
            this.txtTelCel.TabIndex = 9;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(317, 97);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(44, 20);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(367, 94);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(256, 26);
            this.txtCPF.TabIndex = 11;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdNaoIden);
            this.grpSexo.Controls.Add(this.rdMasc);
            this.grpSexo.Controls.Add(this.rdFem);
            this.grpSexo.Location = new System.Drawing.Point(12, 188);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(423, 82);
            this.grpSexo.TabIndex = 12;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdFem
            // 
            this.rdFem.AutoSize = true;
            this.rdFem.Location = new System.Drawing.Point(16, 35);
            this.rdFem.Name = "rdFem";
            this.rdFem.Size = new System.Drawing.Size(99, 24);
            this.rdFem.TabIndex = 0;
            this.rdFem.TabStop = true;
            this.rdFem.Text = "Feminino";
            this.rdFem.UseVisualStyleBackColor = true;
            // 
            // rdMasc
            // 
            this.rdMasc.AutoSize = true;
            this.rdMasc.Location = new System.Drawing.Point(139, 35);
            this.rdMasc.Name = "rdMasc";
            this.rdMasc.Size = new System.Drawing.Size(105, 24);
            this.rdMasc.TabIndex = 1;
            this.rdMasc.TabStop = true;
            this.rdMasc.Text = "Masculino";
            this.rdMasc.UseVisualStyleBackColor = true;
            // 
            // rdNaoIden
            // 
            this.rdNaoIden.AutoSize = true;
            this.rdNaoIden.Location = new System.Drawing.Point(263, 35);
            this.rdNaoIden.Name = "rdNaoIden";
            this.rdNaoIden.Size = new System.Drawing.Size(141, 24);
            this.rdNaoIden.TabIndex = 2;
            this.rdNaoIden.TabStop = true;
            this.rdNaoIden.Text = "Não Identificou";
            this.rdNaoIden.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(883, 25);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(94, 73);
            this.btnCarregar.TabIndex = 14;
            this.btnCarregar.Text = "Carregar Imagem";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(883, 130);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 71);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar Imagem";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // grpEndereco
            // 
            this.grpEndereco.Controls.Add(this.txtEstado);
            this.grpEndereco.Controls.Add(this.lblEstado);
            this.grpEndereco.Controls.Add(this.txtCidade);
            this.grpEndereco.Controls.Add(this.lblCidade);
            this.grpEndereco.Controls.Add(this.txtBairro);
            this.grpEndereco.Controls.Add(this.lblBairro);
            this.grpEndereco.Controls.Add(this.txtNumeroCasa);
            this.grpEndereco.Controls.Add(this.lblNumero);
            this.grpEndereco.Controls.Add(this.txtLogradouro);
            this.grpEndereco.Controls.Add(this.lblLogradouro);
            this.grpEndereco.Controls.Add(this.txtCEP);
            this.grpEndereco.Controls.Add(this.lblCEP);
            this.grpEndereco.Location = new System.Drawing.Point(12, 433);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(995, 136);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.TabStop = false;
            this.grpEndereco.Text = "Endereço";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(7, 26);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(45, 20);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(59, 26);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(153, 26);
            this.txtCEP.TabIndex = 1;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(240, 26);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(342, 26);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(646, 26);
            this.txtLogradouro.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 62);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(87, 59);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(125, 26);
            this.txtNumeroCasa.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(280, 62);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(342, 59);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(212, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(573, 62);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(63, 20);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(642, 59);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(164, 26);
            this.txtCidade.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(812, 62);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(883, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(105, 26);
            this.txtEstado.TabIndex = 11;
            // 
            // gpDadosExtras
            // 
            this.gpDadosExtras.Controls.Add(this.chkInstagram);
            this.gpDadosExtras.Controls.Add(this.chkTwitter);
            this.gpDadosExtras.Controls.Add(this.chkFacebook);
            this.gpDadosExtras.Controls.Add(this.chkEmail);
            this.gpDadosExtras.Controls.Add(this.txtInstagram);
            this.gpDadosExtras.Controls.Add(this.lblInstagram);
            this.gpDadosExtras.Controls.Add(this.txtTwitter);
            this.gpDadosExtras.Controls.Add(this.lblTwitter);
            this.gpDadosExtras.Controls.Add(this.txtFacebook);
            this.gpDadosExtras.Controls.Add(this.lblFacebook);
            this.gpDadosExtras.Controls.Add(this.txtEmail);
            this.gpDadosExtras.Controls.Add(this.lblEmail);
            this.gpDadosExtras.Location = new System.Drawing.Point(12, 586);
            this.gpDadosExtras.Name = "gpDadosExtras";
            this.gpDadosExtras.Size = new System.Drawing.Size(995, 164);
            this.gpDadosExtras.TabIndex = 3;
            this.gpDadosExtras.TabStop = false;
            this.gpDadosExtras.Text = "Dados Extras";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 26);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(805, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(7, 60);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(84, 20);
            this.lblFacebook.TabIndex = 2;
            this.lblFacebook.Text = "Facebook:";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(98, 60);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(778, 26);
            this.txtFacebook.TabIndex = 3;
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(7, 95);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(60, 20);
            this.lblTwitter.TabIndex = 4;
            this.lblTwitter.Text = "Twitter:";
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(73, 92);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(803, 26);
            this.txtTwitter.TabIndex = 5;
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Location = new System.Drawing.Point(8, 130);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(85, 20);
            this.lblInstagram.TabIndex = 6;
            this.lblInstagram.Text = "Instagram:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(98, 127);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(778, 26);
            this.txtInstagram.TabIndex = 7;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(882, 28);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(79, 24);
            this.chkEmail.TabIndex = 8;
            this.chkEmail.Text = "E-mail";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkFacebook
            // 
            this.chkFacebook.AutoSize = true;
            this.chkFacebook.Location = new System.Drawing.Point(882, 62);
            this.chkFacebook.Name = "chkFacebook";
            this.chkFacebook.Size = new System.Drawing.Size(106, 24);
            this.chkFacebook.TabIndex = 9;
            this.chkFacebook.Text = "Facebook";
            this.chkFacebook.UseVisualStyleBackColor = true;
            // 
            // chkTwitter
            // 
            this.chkTwitter.AutoSize = true;
            this.chkTwitter.Location = new System.Drawing.Point(883, 94);
            this.chkTwitter.Name = "chkTwitter";
            this.chkTwitter.Size = new System.Drawing.Size(82, 24);
            this.chkTwitter.TabIndex = 10;
            this.chkTwitter.Text = "Twitter";
            this.chkTwitter.UseVisualStyleBackColor = true;
            // 
            // chkInstagram
            // 
            this.chkInstagram.AutoSize = true;
            this.chkInstagram.Location = new System.Drawing.Point(883, 129);
            this.chkInstagram.Name = "chkInstagram";
            this.chkInstagram.Size = new System.Drawing.Size(107, 24);
            this.chkInstagram.TabIndex = 11;
            this.chkInstagram.Text = "Instagram";
            this.chkInstagram.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(24, 778);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(135, 37);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(187, 778);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(136, 37);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(354, 778);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 37);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(512, 778);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 37);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(680, 778);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(138, 37);
            this.btnLimpa.TabIndex = 8;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(859, 778);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 37);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackgroundImage = global::Formulario.Properties.Resources.trabalhoC_;
            this.pcbFoto.Image = global::Formulario.Properties.Resources.Cara_Delevingne1;
            this.pcbFoto.InitialImage = global::Formulario.Properties.Resources.Cara_Delevingne;
            this.pcbFoto.Location = new System.Drawing.Point(642, 26);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(234, 280);
            this.pcbFoto.TabIndex = 13;
            this.pcbFoto.TabStop = false;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(883, 223);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(94, 72);
            this.btnOcultar.TabIndex = 16;
            this.btnOcultar.Text = "Ocultar foto";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 827);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gpDadosExtras);
            this.Controls.Add(this.grpEndereco);
            this.Controls.Add(this.grpDadosPessoais);
            this.Controls.Add(this.lblCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDadosPessoais.ResumeLayout(false);
            this.grpDadosPessoais.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            this.gpDadosExtras.ResumeLayout(false);
            this.gpDadosExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.GroupBox grpDadosPessoais;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdNaoIden;
        private System.Windows.Forms.RadioButton rdMasc;
        private System.Windows.Forms.RadioButton rdFem;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtTelCel;
        private System.Windows.Forms.Label lblTelC;
        private System.Windows.Forms.TextBox txtTelRes;
        private System.Windows.Forms.Label lblTelR;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpEndereco;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.GroupBox gpDadosExtras;
        private System.Windows.Forms.CheckBox chkInstagram;
        private System.Windows.Forms.CheckBox chkTwitter;
        private System.Windows.Forms.CheckBox chkFacebook;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOcultar;
    }
}

