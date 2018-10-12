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

            // ler da tabela USUARIOS a linha que tenha USER_LOGIN igual ao digitado na tela
            // e USER_PWS igual a digitada na tela
            



            // se não encontrou ninguem ( user.Count() == 0), sinalizar cancelamento
            

            // caso contrário, sinalizar sucesso
            

            // fechar o formulário
            Close();
        }
    }
}
