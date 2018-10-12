
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Text.RegularExpressions;

namespace Linq01
{
    // LINQ: Language INtegrated Query
    public partial class Form1 : Form
    {
        List<Empregados> empregados = new List<Empregados>
           {
 			new Empregados { CODFUN = 1, NOME = "OLAVO C. PASSA", SALARIO = 1000.00, COD_DEPTO = 4, COD_CARGO = 17, DATA_ADMISSAO = new DateTime(1986,10,5) },
 			new Empregados { CODFUN = 2, NOME = "JOSE H. ROMEU LEITAO", SALARIO = 600.00, COD_DEPTO = 2, COD_CARGO = 14, DATA_ADMISSAO = new DateTime(1987,5,2) },
 			new Empregados { CODFUN = 3, NOME = "Euvira Loka", SALARIO = 2400.00, COD_DEPTO = 5, COD_CARGO = 2, DATA_ADMISSAO = new DateTime(1986,10,5) },
 			new Empregados { CODFUN = 4, NOME = "PAULO CESAR JUNIOR", SALARIO = 600.00, COD_DEPTO = 8, COD_CARGO = 14, DATA_ADMISSAO = new DateTime(1987,5,6) },
 			new Empregados { CODFUN = 5, NOME = "JOAO LIMA MACHADO DA SILVA", SALARIO = 1200.00, COD_DEPTO = 4, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1993,1,10) },
 			new Empregados { CODFUN = 7, NOME = "MOHAMED ABDULAH ROSEMBERG", SALARIO = 4500.00, COD_DEPTO = 11, COD_CARGO = 11, DATA_ADMISSAO = new DateTime(1987,2,3) },
 			new Empregados { CODFUN = 8, NOME = "ELIANE P. DE KANA", SALARIO = 1200.00, COD_DEPTO = 6, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1986,5,4) },
 			new Empregados { CODFUN = 9, NOME = "RUDGE RAMOS SANTANA DA PENHA", SALARIO = 800.00, COD_DEPTO = 2, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(1985,12,23) },
 			new Empregados { CODFUN = 10, NOME = "MARIA  C. BASTIANA", SALARIO = 1200.00, COD_DEPTO = 5, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1987,6,14) },
 			new Empregados { CODFUN = 11, NOME = "ROLANDO ESCADA ABAIXO", SALARIO = 1200.00, COD_DEPTO = 3, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1989,1,1) },
 			new Empregados { CODFUN = 12, NOME = "JOAO K. PACHO", SALARIO = 1200.00, COD_DEPTO = 4, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1985,1,1) },
 			new Empregados { CODFUN = 13, NOME = "OSMAR ESTAO BRAVOS", SALARIO = 2400.00, COD_DEPTO = 5, COD_CARGO = 2, DATA_ADMISSAO = new DateTime(1986,1,6) },
 			new Empregados { CODFUN = 14, NOME = "EULER VOCE ESCREVER", SALARIO = 1200.00, COD_DEPTO = 1, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1993,2,3) },
 			new Empregados { CODFUN = 15, NOME = "MARCO O PONTO TODO DIA", SALARIO = 2400.00, COD_DEPTO = 4, COD_CARGO = 2, DATA_ADMISSAO = new DateTime(1982,2,7) },
 			new Empregados { CODFUN = 16, NOME = "ALTAMIR B. ZOUROS AA", SALARIO = 3300.00, COD_DEPTO = 6, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(1988,1,5) },
 			new Empregados { CODFUN = 17, NOME = "ANA LUISA MARIA", SALARIO = 1200.00, COD_DEPTO = 3, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1986,12,4) },
 			new Empregados { CODFUN = 18, NOME = "FUGIRO K. KOMBI", SALARIO = 8300.00, COD_DEPTO = 1, COD_CARGO = 1, DATA_ADMISSAO = new DateTime(1981,12,12) },
 			new Empregados { CODFUN = 19, NOME = "SEBASTIAO P. LANTRA", SALARIO = 8300.00, COD_DEPTO = 2, COD_CARGO = 1, DATA_ADMISSAO = new DateTime(1988,4,6) },
 			new Empregados { CODFUN = 20, NOME = "EURICO E ELE POBRE", SALARIO = 800.00, COD_DEPTO = 2, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(1988,1,9) },
 			new Empregados { CODFUN = 21, NOME = "ASTOLFO LIBERIO PINTO", SALARIO = 500.00, COD_DEPTO = 3, COD_CARGO = 5, DATA_ADMISSAO = new DateTime(1993,10,10) },
 			new Empregados { CODFUN = 22, NOME = "ARNALDO GRANDAO", SALARIO = 800.00, COD_DEPTO = 3, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(1986,6,24) },
 			new Empregados { CODFUN = 23, NOME = "JOAQUIM JUNIOR FILHO", SALARIO = 500.00, COD_DEPTO = 4, COD_CARGO = 5, DATA_ADMISSAO = new DateTime(1984,2,20) },
 			new Empregados { CODFUN = 24, NOME = "ITAMAR E VAI PIORAR", SALARIO = 1200.00, COD_DEPTO = 5, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1992,10,5) },
 			new Empregados { CODFUN = 25, NOME = "MAGNO O BOM", SALARIO = 4500.00, COD_DEPTO = 2, COD_CARGO = 11, DATA_ADMISSAO = new DateTime(1983,7,15) },
 			new Empregados { CODFUN = 26, NOME = "SUJIRO KE FUJA", SALARIO = 5000.00, COD_DEPTO = 5, COD_CARGO = 10, DATA_ADMISSAO = new DateTime(1993,2,10) },
 			new Empregados { CODFUN = 27, NOME = "ARNOLDE SUAS NEGA", SALARIO = 5000.00, COD_DEPTO = 5, COD_CARGO = 10, DATA_ADMISSAO = new DateTime(1996,5,10) },
 			new Empregados { CODFUN = 28, NOME = "TAKARO KAKI NAKARA", SALARIO = 3330.00, COD_DEPTO = 2, COD_CARGO = 9, DATA_ADMISSAO = new DateTime(1993,4,3) },
 			new Empregados { CODFUN = 29, NOME = "AUDALIO PINTO SALGADO", SALARIO = 2400.00, COD_DEPTO = 4, COD_CARGO = 2, DATA_ADMISSAO = new DateTime(1991,5,10) },
 			new Empregados { CODFUN = 30, NOME = "CARLOS MAGNO P SOUZA", SALARIO = 1200.00, COD_DEPTO = 7, COD_CARGO = 3, DATA_ADMISSAO = new DateTime(1996,5,28) },
 			new Empregados { CODFUN = 31, NOME = "MANOEL B.O. TONICO FONTOURA", SALARIO = 3300.00, COD_DEPTO = 14, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(1996,5,29) },
 			new Empregados { CODFUN = 32, NOME = "JOSÉ CARLOS SILVA", SALARIO = 3300.00, COD_DEPTO = 1, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(1998,1,1) },
 			new Empregados { CODFUN = 33, NOME = "ROBERVAL PINTO PENTEADO", SALARIO = 3300.00, COD_DEPTO = 4, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(2001,1,1) },
 			new Empregados { CODFUN = 35, NOME = "MARIANA DA SILVA", SALARIO = 500.00, COD_DEPTO = 3, COD_CARGO = 16, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 36, NOME = "OMAR ESTÁ BRAVO", SALARIO = 800.00, COD_DEPTO = 6, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 38, NOME = "LUIS FERNANDO LEMOS", SALARIO = 600.00, COD_DEPTO = 2, COD_CARGO = 14, DATA_ADMISSAO = new DateTime(2005,1,1) },
 			new Empregados { CODFUN = 40, NOME = "JOAQUIM ALBERTO", SALARIO = 500.00, COD_DEPTO = 2, COD_CARGO = 5, DATA_ADMISSAO = new DateTime(2003,4,5) },
 			new Empregados { CODFUN = 43, NOME = "JOÃO CARLOS DE OLIVEIRA", SALARIO = 5000.00, COD_DEPTO = 1, COD_CARGO = 10, DATA_ADMISSAO = new DateTime(2000,1,1) },
 			new Empregados { CODFUN = 44, NOME = "JORGE DOS SANTOS ROCHA JUNIOR", SALARIO = 500, COD_DEPTO = 1, COD_CARGO = 1, DATA_ADMISSAO = new DateTime(2000,7,1) },
 			new Empregados { CODFUN = 45, NOME = "MARIA LUIZA", SALARIO = 500.00, COD_DEPTO = 3, COD_CARGO = 5, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 46, NOME = "CARLOS ROBERTO JUNIOR FILHO", SALARIO = 3300.00, COD_DEPTO = 4, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(2006,2,11) },
 			new Empregados { CODFUN = 47, NOME = "ANA LUIZA SOUSA FILHO", SALARIO = 800.00, COD_DEPTO = 3, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 48, NOME = "MIKAIL LIXONOPÉVSK", SALARIO = 1200.00, COD_DEPTO = 3, COD_CARGO = 8, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 49, NOME = "ROBERT MELO REGO", SALARIO = 800.00, COD_DEPTO = 1, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(2001,9,11) },
 			new Empregados { CODFUN = 50, NOME = "AUGUSTO SILVEIRA DA SILVA", SALARIO = 890.00, COD_DEPTO = 5, COD_CARGO = 6, DATA_ADMISSAO = new DateTime(2006,6,6) },
 			new Empregados { CODFUN = 51, NOME = "GEORGE BIN BUSH", SALARIO = 4500.00, COD_DEPTO = 1, COD_CARGO = 11, DATA_ADMISSAO = new DateTime(2001,10,10) },
 			new Empregados { CODFUN = 52, NOME = "ARNALDO K.B.SÃO", SALARIO = 890.00, COD_DEPTO = 1, COD_CARGO = 6, DATA_ADMISSAO = new DateTime(1990,1,1) },
 			new Empregados { CODFUN = 53, NOME = "ROGÉRIO F. LIZ", SALARIO = 4500.00, COD_DEPTO = 1, COD_CARGO = 11, DATA_ADMISSAO = new DateTime(1980,1,1) },
 			new Empregados { CODFUN = 54, NOME = "JOSE JOAO PAULO", SALARIO = 1200.00, COD_DEPTO = 8, COD_CARGO = 8, DATA_ADMISSAO = new DateTime(1999,9,9) },
 			new Empregados { CODFUN = 55, NOME = "ARLINDO F. HEIO", SALARIO = 500.00, COD_DEPTO = 6, COD_CARGO = 5, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 57, NOME = "ANTONIO CARLOS PINTO SOUTO", SALARIO = 500.00, COD_DEPTO = 5, COD_CARGO = 5, DATA_ADMISSAO = new DateTime(2004,5,3) },
 			new Empregados { CODFUN = 58, NOME = "MIKAIL GORDA CHOVE", SALARIO = 3330.00, COD_DEPTO = 9, COD_CARGO = 9, DATA_ADMISSAO = new DateTime(2000,9,9) },
 			new Empregados { CODFUN = 59, NOME = "MANUEL INÁCIO DA SILVA (MULA)", SALARIO = 4500.00, COD_DEPTO = 3, COD_CARGO = 11, DATA_ADMISSAO = new DateTime(2005,2,12) },
 			new Empregados { CODFUN = 61, NOME = "RONALDO K. RAMBOLA", SALARIO = 3300.00, COD_DEPTO = 1, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(1990,1,1) },
 			new Empregados { CODFUN = 64, NOME = "LÚCIO G. NEROSO", SALARIO = 890.00, COD_DEPTO = 4, COD_CARGO = 6, DATA_ADMISSAO = new DateTime(2006,1,1) },
 			new Empregados { CODFUN = 66, NOME = "JOSÉ SARNENTO", SALARIO = 8300.00, COD_DEPTO = 1, COD_CARGO = 1, DATA_ADMISSAO = new DateTime(2000,1,1) },
 			new Empregados { CODFUN = 67, NOME = "JOÃO JÓSE DE SOUZA", SALARIO = 800.00, COD_DEPTO = 12, COD_CARGO = 4, DATA_ADMISSAO = new DateTime(1999,5,4) },
 			new Empregados { CODFUN = 68, NOME = "SEVERINO A.B. STADO", SALARIO = 500, COD_DEPTO = 1, COD_CARGO = 1, DATA_ADMISSAO = new DateTime(2000,7,1) },
 			new Empregados { CODFUN = 69, NOME = "RENAN K. NALHEIROS", SALARIO = 3300.00, COD_DEPTO = 8, COD_CARGO = 12, DATA_ADMISSAO = new DateTime(1990,1,1) },
 			new Empregados { CODFUN = 70, NOME = "OSAMA BIN BUSH", SALARIO = 890.00, COD_DEPTO = 1, COD_CARGO = 6, DATA_ADMISSAO = new DateTime(2006,6,24) },
 			new Empregados { CODFUN = 72, NOME = "ROBERTO CARLOS DA SILVA", SALARIO = 4500.00, COD_DEPTO = 1, COD_CARGO = 11, DATA_ADMISSAO = new DateTime(2006,6,24) }
        };
        List<Deptos> deptos = new List<Deptos>
        {
			new Deptos { COD_DEPTO = 1, DEPTO = "PESSOAL"},
			new Deptos { COD_DEPTO = 2, DEPTO = "C.P.D."},
			new Deptos { COD_DEPTO = 3, DEPTO = "CONTROLE DE ESTOQUE"},
			new Deptos { COD_DEPTO = 4, DEPTO = "COMPRAS"},
			new Deptos { COD_DEPTO = 5, DEPTO = "PRODUCAO"},
			new Deptos { COD_DEPTO = 6, DEPTO = "DIRETORIA"},
			new Deptos { COD_DEPTO = 7, DEPTO = "TELEMARKETING"},
			new Deptos { COD_DEPTO = 8, DEPTO = "FINANCEIRO"},
			new Deptos { COD_DEPTO = 9, DEPTO = "RECURSOS HUMANOS"},
			new Deptos { COD_DEPTO = 10, DEPTO = "TREINAMENTO"},
			new Deptos { COD_DEPTO = 11, DEPTO = "PRESIDENCIA"},
			new Deptos { COD_DEPTO = 12, DEPTO = "PORTARIA"},
			new Deptos { COD_DEPTO = 13, DEPTO = "CONTROLADORIA"},
			new Deptos { COD_DEPTO = 14, DEPTO = "P.C.P."}
        };

        List<Cargos> cargos = new List<Cargos>
        {
			new Cargos { COD_CARGO = 1, CARGO = "GERENTE DE GUARANDUN"},
			new Cargos { COD_CARGO = 2, CARGO = "SUPERVISOR DE MINISQUETE"},
			new Cargos { COD_CARGO = 3, CARGO = "COORDENADOR DE TRABLICS"},
			new Cargos { COD_CARGO = 4, CARGO = "AUXILIAR DE GLUB-GLUB"},
			new Cargos { COD_CARGO = 5, CARGO = "OFFICE BOY"},
			new Cargos { COD_CARGO = 6, CARGO = "CONTROLADOR MAKARUZAS"},
			new Cargos { COD_CARGO = 7, CARGO = "MARCENEIRO"},
			new Cargos { COD_CARGO = 8, CARGO = "PRESIDENTE FAXINA"},
			new Cargos { COD_CARGO = 9, CARGO = "MORDOMO POLIVALENTE"},
			new Cargos { COD_CARGO = 10, CARGO = "LUSTRADOR DE JURUPETAS"},
			new Cargos { COD_CARGO = 11, CARGO = "DESENTORTADOR DE BABLICAS"},
			new Cargos { COD_CARGO = 12, CARGO = "CONFERENTE DE RULISGRUBS"},
			new Cargos { COD_CARGO = 13, CARGO = "ENGENGRUBS ELENEVERIS"},
			new Cargos { COD_CARGO = 14, CARGO = "CARREGADOR DE MANJUREBAS"},
			new Cargos { COD_CARGO = 15, CARGO = "ENGOLIDOR DE RELUMEX"},
			new Cargos { COD_CARGO = 16, CARGO = "CAPTURADOR DE RELENFLEX"},
			new Cargos { COD_CARGO = 17, CARGO = "ARREMESSADOR DE GARBUINOS"}
       };



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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            // var x;
            // x = "MAGNO";
            // x = 1.4

            // Query
            var emp = from em in empregados
                      select new
                      {
                          em.CODFUN,
                          em.NOME,
                          em.SALARIO,
                          em.COD_DEPTO,
                          em.COD_CARGO,
                          em.DATA_ADMISSAO
                      };

            dgv.DataSource = emp.ToList();

            // Lambda
            var emp2 = empregados.Select(em => new
            {
                em.CODFUN,
                em.NOME,
                em.SALARIO,
                em.COD_DEPTO,
                em.COD_CARGO,
                em.DATA_ADMISSAO
            });

            tbxResult.Text = "";
            foreach (var item in emp2)
                tbxResult.Text += item.NOME + " - " +
                                  item.SALARIO.ToString() +
                                  Environment.NewLine;

            lblLinhas.Text = emp.Count().ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //ORDER BY NOME

            // Query
           

            // Lambda
           


            //tbxResult.Text = "";
            //foreach (var item in emp2)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

            //lblLinhas.Text = emp.Count().ToString();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //WHERE SALARIO < 5000
            //ORDER BY SALARIO DESC
            // Query

            
            

            // lambda


            //dgv.DataSource = emp.ToList();
            //tbxResult.Text = "";
            //foreach (var item in emp2)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //WHERE SALARIO > 3000 AND SALARIO < 6000
            //ORDER BY SALARIO
            // complete...

            // Query
            
            

            // lambda
            


            //dgv.DataSource = emp.ToList();
            //tbxResult.Text = "";
            //foreach (var item in emp2)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //WHERE DATA_ADMISSAO BETWEEN '2000.1.1' AND DATA_ADMISSAO <= '2000.12.31'
            //ORDER BY DATA_ADMISSAO
            // Dica: para escrever uma constante de data, faça:
            //       new DateTime(2000,1,1)         
            // complete (button5)

            // Query

            
            // lambda
            

            //dgv.DataSource = emp.ToList();
            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SELECT E.CODFUN, E.NOME, D.DEPTO, E.SALARIO, E.COD_DEPTO, E.COD_CARGO, E.DATA_ADMISSAO
            //FROM EMPREGADOS E JOIN TABELADEP D ON E.COD_DEPTO = D.COD_DAPTO
            //WHERE SALARIO < 5000
            //ORDER BY SALARIO DESC

            // query
            

            // lambda
            


            //dgv.DataSource = emp.ToList();

            //tbxResult.Text = "";
            //foreach (var item in emp2)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //SELECT E.CODFUN, E.NOME, D.DEPTO, C.CARGO, E.SALARIO, E.COD_DEPTO, E.COD_CARGO, E.DATA_ADMISSAO
            //FROM EMPREGADOS E JOIN TABELADEP D ON E.COD_DEPTO = D.COD_DAPTO
            //                  JOIN TABELACAR C ON E.COD_CARGO = D.COD_CARGO
            //WHERE SALARIO < 5000
            //ORDER BY SALARIO DESC

            // complete... (button7)
            


            //dgv.DataSource = emp.ToList();

            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //SELECT D.DEPTO, SUM(E.SALARIO) AS TotalSalario
            //FROM EMPREGADOS E JOIN TABELADEP D ON E.COD_DEPTO = D.COD_DEPTO
            //GROUP BY D.DEPTO
            

            //dgv.DataSource = emp.ToList();

            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.CodDepto + " - " +
            //                      item.TotalSalario.ToString() +
            //                      Environment.NewLine;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //SELECT D.COD_DEPTO, D.DEPTO, SUM(E.SALARIO) AS TotalSalario,
            //       MIN(E.SALARIO) AS MenorSalario, MAX(E.SALARIO) AS MaiorSalario,
            //       COUNT(*) AS QtdFunc
            //FROM EMPREGADOS E JOIN TABELADEP D ON E.COD_DEPTO = D.COD_DEPTO
            //GROUP BY D.COD_DEPTO, D.DEPTO
            // ORDER BY TotalSalario
            


            //dgv.DataSource = emp.ToList();

            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.CodDepto + " - " +
            //                      item.TotalSalario.ToString() +
            //                      Environment.NewLine;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            //SELECT D.COD_DEPTO, D.DEPTO, SUM(E.SALARIO) AS TotalSalario,
            //       MIN(E.SALARIO) AS MenorSalario, MAX(E.SALARIO) AS MaiorSalario,
            //       COUNT(*) AS QtdFunc
            //FROM EMPREGADOS E JOIN TABELADEP D ON E.COD_DEPTO = D.COD_DEPTO
            //WHERE E.SALARIO < 8000 
            //GROUP BY D.COD_DEPTO, D.DEPTO 
            // HAVING SUM(E.SALARIO) > 18000
            //ORDER BY TotalSalario

            // Dica:
            // Para fazer "HAVING" com Linq basta colocar where após o group ... by

            // complete

            


            //dgv.DataSource = emp.ToList();
            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.CodDepto + " - " +
            //                      item.TotalSalario.ToString() +
            //                      Environment.NewLine;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //WHERE NOME LIKE 'MARIA%'
            //ORDER BY SALARIO
            //
            // string1.StartsWith(string2) -> true se string1 começa com string2
            // string1.EndsWith(string2) -> true se string1 termina com string2
            // string1.Contains(string2) -> true se string1 contem string2

            // complete...
            
            //dgv.DataSource = emp.ToList();

            //tbxResult.Text = "";
            //foreach (var item in emp2)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //WHERE NOME LIKE '%MARIA'
            //ORDER BY SALARIO

            // COMPLETE...


            //dgv.DataSource = emp.ToList();

            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //SELECT CODFUN, NOME, SALARIO, COD_DEPTO, COD_CARGO, DATA_ADMISSAO
            //FROM EMPREGADOS
            //WHERE NOME LIKE '%MARIA%'
            //ORDER BY SALARIO

            // COMPLETE....


            //dgv.DataSource = emp.ToList();

            //lblLinhas.Text = emp.Count().ToString();

            //tbxResult.Text = "";
            //foreach (var item in emp)
            //    tbxResult.Text += item.NOME + " - " +
            //                      item.SALARIO.ToString() +
            //                      Environment.NewLine;

        }
    }

    class Empregados
    {
        private int _CODFUN;
        private string _NOME;
        private double _SALARIO;
        private int _COD_DEPTO;
        private int _COD_CARGO;
        private DateTime _DATA_ADMISSAO;

        public int CODFUN
        {
            get { return _CODFUN; }
            set { _CODFUN = value; }
        }
        public string NOME
        {
            get { return _NOME; }
            set { _NOME = value; }
        }
        public double SALARIO
        {
            get { return _SALARIO; }
            set { _SALARIO = value; }
        }
        public int COD_DEPTO
        {
            get { return _COD_DEPTO; }
            set { _COD_DEPTO = value; }
        }
        public int COD_CARGO
        {
            get { return _COD_CARGO; }
            set { _COD_CARGO = value; }
        }
        public DateTime DATA_ADMISSAO
        {
            get { return _DATA_ADMISSAO; }
            set { _DATA_ADMISSAO = value; }
        }
    }

    class Deptos
    {
        public int COD_DEPTO;
        public string DEPTO;
    }

    class Cargos
    {
        public int COD_CARGO;
        public string CARGO;
    }
}
