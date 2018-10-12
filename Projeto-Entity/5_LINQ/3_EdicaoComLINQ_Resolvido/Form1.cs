using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqEdicao
{
    public partial class Form1 : Form
    {

        PEDIDOSEntities pedidos = new PEDIDOSEntities();

        enum EditStatus  {Consulta, Altera, Inclui};
        EditStatus recStatus;
   

        int codcli = 0;

        Exception getInnerException(Exception ex)
        {
            if (ex.InnerException != null)
                return getInnerException(ex.InnerException);
            else
                return ex;
        }


        public Form1()
        {
            InitializeComponent();
        }


        private void btnFiltra_Click(object sender, EventArgs e)
        {
            // COM QUERY
            //var clientes = from c in pedidos.CLIENTES
            //               where c.NOME.Contains(tbxFiltraNome.Text) &&
            //                     c.ESTADO.StartsWith(tbxFiltraUF.Text)
            //               orderby c.NOME
            //               select new
            //               {
            //                   c.CODCLI,
            //                   c.NOME,
            //                   c.FANTASIA,
            //                   c.ENDERECO,
            //                   c.BAIRRO,
            //                   c.CIDADE,
            //                   c.ESTADO,
            //                   c.CEP,
            //                   c.CNPJ,
            //                   c.INSCRICAO,
            //                   c.E_MAIL,
            //                   c.FONE1,
            //                   c.FAX
            //               };
            var clientes = pedidos.CLIENTES
                           .Where(c => c.NOME.Contains(tbxFiltraNome.Text) &&
                                       c.ESTADO.StartsWith(tbxFiltraUF.Text))
                           .OrderBy(c => c.NOME)
                           .Select(c => new
                           {
                               c.CODCLI,
                               c.NOME,
                               c.FANTASIA,
                               c.ENDERECO,
                               c.BAIRRO,
                               c.CIDADE,
                               c.ESTADO,
                               c.CEP,
                               c.CNPJ,
                               c.INSCRICAO,
                               c.E_MAIL,
                               c.FONE1,
                               c.FAX
                           });


            // o resultado da consulta com Linq é uma lista 
            // NÃO INDEXÁVEL ( [n] ). A propriedade DataSource
            // exige uma lista indexável. O método ToList()
            // faz isso.
            bsClientes.DataSource = clientes.ToList();
            // associar o grid ao BindingSource
            dgvClientes.DataSource = bsClientes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();

            tbxCODCLI.DataBindings.Add("Text", bsClientes, "CODCLI");
            tbxNOME.DataBindings.Add("Text", bsClientes, "NOME");
            tbxFANTASIA.DataBindings.Add("Text", bsClientes, "FANTASIA");
            tbxENDERECO.DataBindings.Add("Text", bsClientes, "ENDERECO");
            tbxBAIRRO.DataBindings.Add("Text", bsClientes, "BAIRRO");
            tbxCIDADE.DataBindings.Add("Text", bsClientes, "CIDADE");
            tbxESTADO.DataBindings.Add("Text", bsClientes, "ESTADO");
            tbxCEP.DataBindings.Add("Text", bsClientes, "CEP");
            tbxCNPJ.DataBindings.Add("Text", bsClientes, "CNPJ");
            tbxINSCRICAO.DataBindings.Add("Text", bsClientes, "INSCRICAO");
            tbxFONE1.DataBindings.Add("Text", bsClientes, "FONE1");
            tbxE_MAIL.DataBindings.Add("Text", bsClientes, "E_MAIL");
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            dgvClientes.Enabled = false;

            groupBox2.Enabled = true;

            tbxNOME.Focus();
            recStatus = EditStatus.Altera;
        }

       

        private void btnInclui_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            dgvClientes.Enabled = false;

            groupBox2.Enabled = true;

            tbxNOME.Focus();

            foreach (Control ctl in groupBox2.Controls)
            {
                //if (ctl is TextBox) (ctl as TextBox).Clear();
                //if (ctl is TextBox) ((TextBox)ctl).Clear();
                if (ctl is TextBox) ctl.Text = "";
            }

            recStatus = EditStatus.Inclui;

        }

        private void btnGrava_Click(object sender, EventArgs e)
        {

           
            if (recStatus == EditStatus.Altera)
            {
                altera();
            }
            else
            {
                inclui();
                
            }
           

            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            dgvClientes.Enabled = true;

            btnFiltra.PerformClick();
            recStatus = EditStatus.Consulta;

            Text = codcli.ToString();

           // bsClientes.Position = bsClientes.Find("CODCLI", codcli);
        }

        void altera()
        {
            // descobrir qual é o codcli que acabamos de alterar
            codcli = Convert.ToInt32(tbxCODCLI.Text);
            // ler do banco de dados (Entity Data Model) os dados
            // atuais do cliente em questão
            var cliente = pedidos.CLIENTES
                          .Where(c => c.CODCLI == codcli)
                          .First();
            //            .Single();
            //            .ToList()[0];
            // gravar nesse cliente que acabamos de ler, os dados
            // digitados na tela (novos dados do cliente)
            cliente.NOME = tbxNOME.Text;
            cliente.FANTASIA = tbxFANTASIA.Text;
            cliente.ENDERECO = tbxENDERECO.Text;
            cliente.BAIRRO = tbxBAIRRO.Text;
            cliente.CIDADE = tbxCIDADE.Text;
            cliente.ESTADO = tbxESTADO.Text;
            cliente.CEP = tbxCEP.Text;
            cliente.CNPJ = tbxCNPJ.Text;
            cliente.INSCRICAO = tbxINSCRICAO.Text;
            cliente.FONE1 = tbxFONE1.Text;
            cliente.E_MAIL = tbxE_MAIL.Text;
            // esse cliente, NA MEMÓRIA, vai ficar com o status de 
            // MODIFICADO, dentro do Entity Data Model
            // pedidos.Entry(cliente).State == EntityState.<opções>
            try
            {
                // o EDM vai perceber que existe um cliente com status
                // de MODIFICADO e então vai gerar um comando UPDATE
                // para atualizar a tabela
                pedidos.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void inclui()
        {
            // cria um novo objeto da classe CLIENTES
            CLIENTES cliente = new CLIENTES();
            // colocar nesse novo cliente, os dados digitados na tela
            cliente.NOME = tbxNOME.Text;
            cliente.FANTASIA = tbxFANTASIA.Text;
            cliente.ENDERECO = tbxENDERECO.Text;
            cliente.BAIRRO = tbxBAIRRO.Text;
            cliente.CIDADE = tbxCIDADE.Text;
            cliente.ESTADO = tbxESTADO.Text;
            cliente.CEP = tbxCEP.Text;
            cliente.CNPJ = tbxCNPJ.Text;
            cliente.INSCRICAO = tbxINSCRICAO.Text;
            cliente.FONE1 = tbxFONE1.Text;
            cliente.E_MAIL = tbxE_MAIL.Text;
            // adicionar esse novo cliente ao Entity Data Model
            pedidos.CLIENTES.Add(cliente);
            // vai ficar com status de INSERIDO
            try
            {
                pedidos.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão?", "Cuidado",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // descobrir qual é o codcli que acabamos de alterar
                codcli = Convert.ToInt32(tbxCODCLI.Text);
                // ler do banco de dados (Entity Data Model) os dados
                // atuais do cliente em questão
                var cliente = pedidos.CLIENTES
                              .Where(c => c.CODCLI == codcli)
                              .First();
                //            .Single();
                //            .ToList()[0];

                // remover o cliente do Entity Data Model
                pedidos.CLIENTES.Remove(cliente);
                // vai ficar com status de excluido
                try
                {
                    pedidos.SaveChanges();
                    btnFiltra.PerformClick();
                }
                catch (Exception ex)
                {
                    ex = getInnerException(ex);

                    string msg = ex.Message;
                    if (msg.Contains("FK_PEDIDOS_CLIENTES"))
                        msg = "Exitem pedidos para esse cliente...";

                    MessageBox.Show(msg);
                }

            }
        }




    }
}
