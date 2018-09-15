using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpDadosPessoais_Enter(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.Cara_Delevingne;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pcbFoto.Image = null;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCEP.Clear();
            txtCidade.Clear();
            txtCodigo.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtFacebook.Clear();
            txtNome.Clear();
            txtNumeroCasa.Clear();
            txtRG.Clear();
            txtTelCel.Clear();
            txtTelRes.Clear();
            txtTwitter.Clear();
            txtLogradouro.Clear();
            txtInstagram.Clear();
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Cadastro",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            pcbFoto.Visible = false;
        }
    }
}
