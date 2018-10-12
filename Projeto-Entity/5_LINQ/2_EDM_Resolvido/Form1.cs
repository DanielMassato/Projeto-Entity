using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExEDM_Pedidos
{
    public partial class Form1 : Form
    {
        PEDIDOSEntities ped = new PEDIDOSEntities();

        public Form1()
        {
            InitializeComponent();
        }

        /*
         var <nome> = from <id1> in <lista1>
           [ join <id2> in <lista2> on <id1>.<campoCave1> equals <id2>.<campoChave2> ]
           [ join ... ] 
           [ where ( <codiçãoFiltroBase> ) ]
           [ group <id> by new { <chaveAgrupamento> } into <idGrupo> ]
           [ where ( <condiçãoHaving > ) ]
           [ orderby ( <campoOrderBy> )) [descending] ]
           [ select new { <listaDeCampos> } ]


            Funções de agregação para groupby

            <idGrupo>.Sum( expr )
            <idGrupo>.Min( expr )
            <idGrupo>.Max( expr )
            <idGrupo>.Count( expr )
            <idGrupo>.Average( expr )
         */
        private void button1_Click(object sender, EventArgs e)
        {
            // seleciona todas as linhas da tabela pedidos
            // SELECT NUM_PEDIDO, DATA_ALTERACAO, VLR_TOTAL, SITUACAO
            // FROM PEDIDOS

            // COM QUERY
            var pedidos = from p in ped.PEDIDOS
                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO
                          };

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS.Select(p => new
            {
                p.NUM_PEDIDO,
                p.DATA_EMISSAO,
                p.VLR_TOTAL,
                p.SITUACAO
            });

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();
            lblLinhas.Text = pedidos.Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // seleciona todas as linhas da tabela pedidos de Janeiro de 2007
            // SELECT NUM_PEDIDO, DATA_EMISSAO, VLR_TOTAL, SITUACAO
            // FROM PEDIDOS
            // WHERE DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31'

            // Complete
            var pedidos = from p in ped.PEDIDOS
                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)
                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO
                          };

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)
            .Select(p => new
            {
                p.NUM_PEDIDO,
                p.DATA_EMISSAO,
                p.VLR_TOTAL,
                p.SITUACAO
            });

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // seleciona todas as linhas da tabela pedidos de Janeiro de 2007
            // mostrando o nome do vendedor
            // SELECT 
            //    P.NUM_PEDIDO, P.DATA_EMISSAO, P.VLR_TOTAL, P.SITUACAO,
            //    V.NOME AS VENDEDOR
            // FROM PEDIDOS P JOIN VENDEDORES V ON P.CODVEN = V.CODVEN
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31'

            // Complete - button3
            var pedidos = from p in ped.PEDIDOS

                          join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN

                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)
                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO,
                              Vendedor = v.NOME
                          };

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)
            
            .Join(ped.VENDEDORES, p => p.CODVEN, v => v.CODVEN,
                     (p, v) => new
                        {
                            p.NUM_PEDIDO,
                            p.DATA_EMISSAO,
                            p.VLR_TOTAL,
                            p.SITUACAO,
                            Vendedor = v.NOME
                        });
            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // seleciona todas as linhas da tabela pedidos de Janeiro de 2007
            // mostrando o nome do vendedor e do cliente
            // SELECT 
            //    P.NUM_PEDIDO, P.DATA_ALTERACAO, P.VLR_TOTAL, P.SITUACAO,
            //    V.NOME AS VENDEDOR, C.NOME AS CLIENTE
            // FROM PEDIDOS P JOIN VENDEDORES V ON P.CODVEN = V.CODVEN
            //                JOIN CLIENTES C ON P.CODCLI = V.CODCLI
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31'

            // Complete - button 4
            // COM QUERY
            var pedidos = from p in ped.PEDIDOS

                          join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN
                          join c in ped.CLIENTES on p.CODCLI equals c.CODCLI

                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)
                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO,
                              Vendedor = v.NOME,
                              Cliente = c.NOME
                          };

            // COM LAMBDA - button4
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)

            .Join(ped.VENDEDORES, p => p.CODVEN, v => v.CODVEN,
                     (p, v) => new {p,v})
            .Join(ped.CLIENTES, pv => pv.p.CODCLI, c => c.CODCLI,
                  (pv, c) => new
                     {
                         pv.p.NUM_PEDIDO,
                         pv.p.DATA_EMISSAO,
                         pv.p.VLR_TOTAL,
                         pv.p.SITUACAO,
                         Vendedor = pv.v.NOME,
                         Cliente = c.NOME
                     });

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Idem anterior onde o nome do CLIENTE comece com BRINDES
            // SELECT 
            //    P.NUM_PEDIDO, P.DATA_ALTERACAO, P.VLR_TOTAL, P.SITUACAO,
            //    V.NOME AS VENDEDOR, C.NOME AS CLIENTE
            // FROM PEDIDOS P JOIN VENDEDORES V ON P.CODVEN = V.CODVEN
            //                JOIN CLIENTES C ON P.CODCLI = V.CODCLI
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31' AND
            //       C.NOME LIKE 'BRINDES%'

            // Complete - button5
            var pedidos = from p in ped.PEDIDOS

                          join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN
                          join c in ped.CLIENTES on p.CODCLI equals c.CODCLI

                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31) 
                                && c.NOME.StartsWith("BRINDES")
                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO,
                              Vendedor = v.NOME,
                              Cliente = c.NOME
                          };

            // COM LAMBDA - button5
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1
                        // como tem chave estrangeira
                        && p.CLIENTES.NOME.StartsWith("BRINDES"))

            .Join(ped.VENDEDORES, p => p.CODVEN, v => v.CODVEN,
                     (p, v) => new { p, v })
            .Join(ped.CLIENTES, pv => pv.p.CODCLI, c => c.CODCLI,
                  (pv, c) => new
                  {
                      pv.p.NUM_PEDIDO,
                      pv.p.DATA_EMISSAO,
                      pv.p.VLR_TOTAL,
                      pv.p.SITUACAO,
                      Vendedor = pv.v.NOME,
                      Cliente = c.NOME
                  });

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Total vendido por cada vendedor em Jan/2007
            // SELECT V.CODVEN, V.NOME AS VENDEDOR, 
            //        SUM(P.VLR_TOTAL) AS TotVendido
            // FROM PEDIDOS P JOIN VENDEDORES V ON P.CODVEN = V.CODVEN            
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31' 
            // GROUP BY V.CODVEN, V.NOME

            // Complete - BUTTON6
            // COM QUERY
            var pedidos = from p in ped.PEDIDOS
                          join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN
                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)

                          group p by new {v.CODVEN, v.NOME} into g

                          select new
                          {
                              CodVendedor = g.Key.CODVEN,
                              Vendedor = g.Key.NOME,
                              TotVendido = g.Sum(p => p.VLR_TOTAL)
                          };

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)
            .GroupBy(p => new { p.CODVEN, p.VENDEDORES.NOME })
            .Select(g => new
            {
                CodVendedor = g.Key.CODVEN,
                Vendedor = g.Key.NOME,
                TotVendido = g.Sum(p => p.VLR_TOTAL)
            });
                
            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Total comprado por cada cliente em Jan/2007
            // SELECT C.CODCLI, C.NOME AS CLIENTE, 
            //        SUM(P.VLR_TOTAL) AS TotVendido
            // FROM PEDIDOS P JOIN CLIENTES C ON P.CODCLI = C.CODCLI
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31' 
            // GROUP BY C.CODCLI, C.NOME

            // Complete            
            var pedidos = from p in ped.PEDIDOS
                          //join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN
                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)

                          group p by new { p.CODCLI, p.CLIENTES.NOME } into g

                          select new
                          {
                              CodCliente = g.Key.CODCLI,
                              Cliente = g.Key.NOME,
                              TotComprado = g.Sum(p => p.VLR_TOTAL)
                          };

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)
            .GroupBy(p => new { p.CODCLI, p.CLIENTES.NOME })
            .Select(g => new
            {
                CodCliente = g.Key.CODCLI,
                Cliente = g.Key.NOME,
                TotComprado = g.Sum(p => p.VLR_TOTAL)
            });

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Total comprado por cada cliente em Jan/2007
            // mas somente os clientes que totalizaram mais de 50000

            // SELECT C.CODCLI, C.NOME AS CLIENTE, 
            //        SUM(P.VLR_TOTAL) AS TotVendido
            // FROM PEDIDOS P JOIN CLIENTES C ON P.CODCLI = C.CODCLI
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31' 
            // GROUP BY C.CODCLI, C.NOME HAVING SUM(P.VLR_TOTAL)>5000

            // Complete
            var pedidos = from p in ped.PEDIDOS
                              //join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN
                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)

                          group p by new { p.CODCLI, p.CLIENTES.NOME } into g

                          where g.Sum(p => p.VLR_TOTAL) > 5000

                          select new
                          {
                              CodCliente = g.Key.CODCLI,
                              Cliente = g.Key.NOME,
                              TotComprado = g.Sum(p => p.VLR_TOTAL)
                          };

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)
            .GroupBy(p => new { p.CODCLI, p.CLIENTES.NOME })
            .Select(g => new
            {
                CodCliente = g.Key.CODCLI,
                Cliente = g.Key.NOME,
                TotComprado = g.Sum(p => p.VLR_TOTAL)
            }).Where(fin => fin.TotComprado > 5000);

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Total comprado por cada cliente em Jan/2007
            // deve mostrar os 10 que mais compraram

            // SELECT TOP 10 C.CODCLI, C.NOME AS CLIENTE, 
            //        SUM(P.VLR_TOTAL) AS TotVendido
            // FROM PEDIDOS P JOIN CLIENTES C ON P.CODCLI = C.CODCLI
            // WHERE P.DATA_EMISSAO BETWEEN '2007.1.1' AND '2007.1.31' 
            // GROUP BY C.CODCLI, C.NOME
            // ORDER BY TotVendido DESC

            // Para fazer TOP n, coloque toda a expressão LINQ
            // entre parênteses e use o método Take(n):
            // (from....).Take(10)
            // COM QUERY
            var pedidos = (from p in ped.PEDIDOS
                              //join v in ped.VENDEDORES on p.CODVEN equals v.CODVEN
                          where p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31)
                          group p by new { p.CODCLI, p.CLIENTES.NOME } into g

                          orderby g.Sum(p => p.VLR_TOTAL) descending
                          select new
                          {
                              CodCliente = g.Key.CODCLI,
                              Cliente = g.Key.NOME,
                              TotComprado = g.Sum(p => p.VLR_TOTAL)
                          }).Take(10);

            // COM LAMBDA
            var pedidos2 = ped.PEDIDOS
            .Where(p => p.DATA_EMISSAO.Value.Year == 2007 &&
                        p.DATA_EMISSAO.Value.Month == 1)
            .GroupBy(p => new { p.CODCLI, p.CLIENTES.NOME })
            .OrderByDescending(g => g.Sum(p => p.VLR_TOTAL))
            .Select(g => new
            {
                CodCliente = g.Key.CODCLI,
                Cliente = g.Key.NOME,
                TotComprado = g.Sum(p => p.VLR_TOTAL)
            }).Take(10);

            dgv1.DataSource = pedidos.ToList();
            dgv2.DataSource = pedidos2.ToList();

            lblLinhas.Text = pedidos.Count().ToString();
        }

    }
}
