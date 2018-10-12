using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace TreeViewRecursaoBD
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=NOTEDELL\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PEDIDOS");

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método recursivo para ler os registros da tabela CATEGORIAS e
        /// mostrar no TreeView no formato de árvore
        /// </summary>
        /// <param name="codPai">Código da categoria "Pai"</param>
        /// <param name="no">Nó do TreeView</param>
        void carregaGrupos(int codPai, TreeNode no)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM CATEGORIAS 
                                WHERE COD_CAT_PAI = " + codPai;
            DataTable tbFilhos = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(tbFilhos);
            for (int i = 0; i < tbFilhos.Rows.Count; i++)
            {
                TreeNode filho;
                int cod = (int)tbFilhos.Rows[i]["COD_CAT"];
                //cod.ToString("0000") + " - " + 
                string cat = tbFilhos.Rows[i]["CATEGORIA"].ToString();
                if (no == null)
                    filho = tree.Nodes.Add(cod.ToString("0000") +
                                            codPai.ToString("0000"),
                                            cat,
                                            1, 0);
                else
                    filho = no.Nodes.Add(cod.ToString("0000") +
                                            codPai.ToString("0000"),
                                            cat,
                                            1, 0);
                filho.Tag = new Dados
                {
                    COD_CAT = cod,
                    CATEGORIA = cat,
                    COD_CAT_PAI = codPai
                };
                carregaGrupos((int)tbFilhos.Rows[i]["COD_CAT"], filho);
            }
            tbFilhos.Dispose();
            da.Dispose();
            cmd.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tree.Nodes.Clear();
            carregaGrupos(0, null);
        }
        // executado após um nó ser selecionado. Troca a figura do nó
        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
        // executado após um nó ser fechado. Troca a figura do nó
        private void tree_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }
        // executado após um nó ter o seu texto alterado. Grava o novo texto na tabela CATEGORIAS
        private void tree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            int cod = Convert.ToInt32(e.Node.Name.Substring(0, 4));
            int pai = Convert.ToInt32(e.Node.Name.Substring(4, 4));

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE CATEGORIAS SET CATEGORIA = ?
                                WHERE COD_CAT = ?";

            cmd.Parameters.AddWithValue("CAT", e.Label);
            cmd.Parameters.AddWithValue("cod", cod);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            e.Node.Tag = new Dados
            {
                COD_CAT = cod,
                CATEGORIA = e.Label,
                COD_CAT_PAI = pai
            };
        }
        // insere "nó filho" ou "nó irmão" dependendo da propriedade Tag do item de menu que chamou o método
        private void inserirIrmãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cod = tree.SelectedNode.Name.Substring(0, 4);
            string pai = tree.SelectedNode.Name.Substring(4, 4);
            string tag = ((ToolStripMenuItem)sender).Tag.ToString();
            OleDbCommand cmd = conn.CreateCommand();            
            cmd.CommandText = @"INSERT INTO CATEGORIAS VALUES (?,?)";
            // se tag é zero, insere nó filho, caso contrário insere nó irmão
            string paramPai = tag == "0" ? cod : pai;

            cmd.Parameters.AddWithValue("CAT", "Novo Item");
            cmd.Parameters.AddWithValue("pai", paramPai);

            conn.Open();
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT @@IDENTITY AS ID";
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int id = Convert.ToInt32(dr["ID"]);
            cod = id.ToString("0000");
            conn.Close();

            TreeNode no;
            if (tag == "0")
                no = tree.SelectedNode;
            else
                no = tree.SelectedNode.Parent;

            TreeNode novo;
            if (no == null)
                novo = tree.Nodes.Add(cod + pai, "Novo Item", 1, 0);
            else
                novo = no.Nodes.Add(cod + pai, "Novo Item", 1, 0);

            novo.Tag = new Dados
            {
                COD_CAT = Convert.ToInt32(cod),
                CATEGORIA = "Novo Item",
                COD_CAT_PAI = Convert.ToInt32(pai)
            };

            tree.SelectedNode = novo;
        }

        // método recursivo para ler o código de todos os nós filhos de outro nó
        void leFilhos(ArrayList cod, TreeNode no)
        {
            for (int i = 0; i < no.Nodes.Count; i++)
            {
                cod.Add(Convert.ToInt32(no.Nodes[i].Name.Substring(0, 4)));
                if (no.Nodes[i].Nodes.Count > 0)
                    leFilhos(cod, no.Nodes[i]);
            }
        }

        // exclui o nó selecionado e todos os seus dependentes
        private void excluiItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode no = tree.SelectedNode;

            ArrayList cod = new ArrayList();
            cod.Add(Convert.ToInt32(tree.SelectedNode.Name.Substring(0, 4)));
            leFilhos(cod, no);
            string filhos = "(";
            for (int i = 0; i < cod.Count; i++)
            {
                filhos += cod[i].ToString();
                if (i < cod.Count - 1) filhos += ",";
            }
            filhos += ")";
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE CATEGORIAS WHERE COD_CAT IN " + filhos;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            no.Remove();
        }

        private void tree_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.Name;
            label3.Text = e.Node.FullPath;
        }

        private void abrirTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode no = tree.SelectedNode;
            no.ExpandAll();
        }

        private void fecharTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode no = tree.SelectedNode;
            no.Collapse();
        }
    }

    class Dados
    {
        public int COD_CAT;
        public string CATEGORIA;
        public int COD_CAT_PAI;
    }
}
