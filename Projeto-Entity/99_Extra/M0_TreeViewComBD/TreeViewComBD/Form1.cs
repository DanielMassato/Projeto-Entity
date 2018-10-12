using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TreeViewComBD
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=NOTEDELL\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=VENDAS");

        public Form1()
        {
            InitializeComponent();
        }

        void CarregaSubSubGrupos(TreeNode no, int codGrupo, int codGrupoS1)
        {
            DataTable tbGrupos = new DataTable();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM CAD_PRODUTOS_GRUPOS_S2 
                                WHERE COD_GRUPO = ? AND COD_GRUPO_S1 = ?
                                ORDER BY GRUPO_S2";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            cmd.Parameters.AddWithValue("cod",codGrupo);
            cmd.Parameters.AddWithValue("cod2",codGrupoS1);
            int linhas = da.Fill(tbGrupos);
            for (int i = 0; i < linhas; i++)
            {
                int cod = Convert.ToInt32(tbGrupos.Rows[i]["COD_GRUPO"]);
                int cod2 = Convert.ToInt32(tbGrupos.Rows[i]["COD_GRUPO_S1"]);
                int cod3 = Convert.ToInt32(tbGrupos.Rows[i]["COD_GRUPO_S2"]);
                no.Nodes.Add(cod.ToString("0000")+cod2.ToString("0000")+cod3.ToString("0000"),
                          tbGrupos.Rows[i]["GRUPO_S2"].ToString(),1,0);
            }

        }


        void CarregaSubGrupos(TreeNode no, int codGrupo)
        {
            DataTable tbGrupos = new DataTable();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM CAD_PRODUTOS_GRUPOS_S1 
                                WHERE COD_GRUPO = ?
                                ORDER BY GRUPO_S1";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            cmd.Parameters.AddWithValue("cod",codGrupo);
            int linhas = da.Fill(tbGrupos);
            for (int i = 0; i < linhas; i++)
            {
                int cod = Convert.ToInt32(tbGrupos.Rows[i]["COD_GRUPO"]);
                int cod2 = Convert.ToInt32(tbGrupos.Rows[i]["COD_GRUPO_S1"]);
                TreeNode no2 = no.Nodes.Add(cod.ToString("0000")+cod2.ToString("0000"),
                    tbGrupos.Rows[i]["GRUPO_S1"].ToString(),1,0);
                CarregaSubSubGrupos(no2,cod, cod2);
            }

        }


        void CarregaGrupos()
        {
            DataTable tbGrupos = new DataTable();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM CAD_PRODUTOS_GRUPOS ORDER BY GRUPO";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            int linhas = da.Fill(tbGrupos);
            for (int i = 0; i < linhas; i++)
            {
                int cod = Convert.ToInt32(tbGrupos.Rows[i]["COD_GRUPO"]);
                TreeNode no = tree.Nodes.Add( cod.ToString(), 
                     cod.ToString("0000") + " - " + tbGrupos.Rows[i]["GRUPO"].ToString(), 1, 0);
                CarregaSubGrupos(no,cod);
            }

        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            tree.Nodes.Clear();
            CarregaGrupos();            
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void tree_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }
    }
}
