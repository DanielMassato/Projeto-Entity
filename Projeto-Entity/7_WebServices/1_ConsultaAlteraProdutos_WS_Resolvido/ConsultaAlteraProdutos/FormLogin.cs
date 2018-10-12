using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaAlteraProdutos
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string erro = "";

            // se não encontrou ninguem ( user.Count() == 0), sinalizar cancelamento
            if (FormPrincipal.prods.DadosUsuario(tbxLogin.Text, tbxSenha.Text, ref erro) == null)
            {
                DialogResult = DialogResult.Cancel;
            }
            // caso contrário, sinalizar sucesso
            else
            {
                DialogResult = DialogResult.OK;
            }
            // fechar o formulário
            Close();
        }
    }
}
