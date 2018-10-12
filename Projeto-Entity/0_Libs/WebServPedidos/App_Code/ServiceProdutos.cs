using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ServiceProdutos
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ServiceProdutos : System.Web.Services.WebService
{

    // instancia objeto da classe PEDIDOSEntities para termos
    // acesso às tabelas
    PEDIDOSEntities1 ped = new PEDIDOSEntities1();

    Exception getInnerException(Exception ex)
    {
        if (ex.InnerException == null)
            return ex;
        else
            return getInnerException(ex.InnerException);
    }

    public ServiceProdutos()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<ProdutosConsulta> ListaProdutos(string descr, 
                                       string tipo, ref string erro)
    {
        // variável de retorno do método
        List<ProdutosConsulta> result = new List<ProdutosConsulta>();
        try
        {
            // com Lambda
            result = ped.PRODUTOS
                           .Join(ped.TIPOPRODUTO, p => p.COD_TIPO, t => t.COD_TIPO,
                                 (p, t) => new { p, t })
                           .Join(ped.UNIDADES, pt => pt.p.COD_UNIDADE, u => u.COD_UNIDADE,
                                 (pt, u) => new { pt, u })
                           .Select(ptu => new ProdutosConsulta
                           {
                               ID_PRODUTO = ptu.pt.p.ID_PRODUTO,
                               COD_PRODUTO = ptu.pt.p.COD_PRODUTO,
                               DESCRICAO = ptu.pt.p.DESCRICAO,
                               TIPO = ptu.pt.t.TIPO,
                               UNIDADE = ptu.u.UNIDADE,
                               PRECO_VENDA = ptu.pt.p.PRECO_VENDA,
                               QTD_REAL = ptu.pt.p.QTD_REAL,
                               QTD_MINIMA = ptu.pt.p.QTD_MINIMA
                           })
                           .Where(ptu => ptu.DESCRICAO.Contains(descr) &&
                                         ptu.TIPO.StartsWith(tipo))
                           .OrderBy(ptu => ptu.DESCRICAO).ToList();

            // definir que não houve erro
            erro = "";
            // retornar consulta
            return result;
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);

            erro = ex.Message;
            return null;
        }
    }

    [WebMethod]
    public int ReajustaPrecosIDs(string ids, decimal porc, ref string erro)
    {
        SqlCommand cmd = (SqlCommand)ped.Database.Connection.CreateCommand();
        cmd.CommandText = @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
                            WHERE ID_PRODUTO IN (" + ids + ")";

        cmd.Parameters.AddWithValue("@fator", 1 + porc / 100);

        try
        {
            cmd.Connection.Open();
            int linhas = cmd.ExecuteNonQuery();
            erro = "";
            return linhas;
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
            return -1;
        }
        finally
        {
            cmd.Connection.Close();
        }
    }

    [WebMethod]
    public List<TIPOPRODUTO> ListaTipos(ref string erro)
    {
        try
        {

            // colocar os elementos na lista de retorno
            List<TIPOPRODUTO> result = new List<TIPOPRODUTO>();

            result = ped.TIPOPRODUTO.OrderBy(t => t.TIPO).ToList();


            erro = "";
            return result;
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
            return null;
        }
    }

    [WebMethod]
    public List<UNIDADES> ListaUnidades(ref string erro)
    {
        try
        {

            // colocar os elementos na lista de retorno
            List<UNIDADES> result = new List<UNIDADES>();

            result = ped.UNIDADES.OrderBy(t => t.UNIDADE).ToList();

            erro = "";
            return result;
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
            return null;
        }
    }

    [WebMethod]
    public PRODUTOS FichaProduto(int idProduto, ref string erro)
    {
        try
        {
            // busca o produto qe tem ID igual ao recebido como parâmetro
            var pr = ped.PRODUTOS.Where(p => p.ID_PRODUTO == idProduto);
            erro = "";
            // se não trouxe nada...
            if (pr.Count() == 0) return null;
            // retornar objeto da classe PRODUTOS contendo os campos do
            // produto encontrado
            return new PRODUTOS
            {
                ID_PRODUTO = pr.First().ID_PRODUTO,
                COD_PRODUTO = pr.First().COD_PRODUTO,
                DESCRICAO = pr.First().DESCRICAO,
                COD_TIPO = pr.First().COD_TIPO,
                COD_UNIDADE = pr.First().COD_UNIDADE,
                CLAS_FISC = pr.First().CLAS_FISC,
                PESO_LIQ = pr.First().PESO_LIQ,
                IPI = pr.First().IPI,
                PRECO_CUSTO = pr.First().PRECO_CUSTO,
                PRECO_VENDA = pr.First().PRECO_VENDA,
                QTD_ESTIMADA = pr.First().QTD_ESTIMADA,
                QTD_REAL = pr.First().QTD_REAL,
                QTD_MINIMA = pr.First().QTD_MINIMA
            };
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
            return null;
        }
    }

    [WebMethod]
    public void AlterProduto(PRODUTOS pr, ref string erro)
    {
        try
        {
            // consultar o produto que será alterado
            var prod = ped.PRODUTOS.Where(p => p.ID_PRODUTO == pr.ID_PRODUTO).First();
            // alterar os dados deste produto com os dados digitados na tela
            // arquivo AlteraProduto.txt (172.16.2.25)
            prod.COD_PRODUTO = pr.COD_PRODUTO;
            prod.DESCRICAO = pr.DESCRICAO;
            prod.COD_TIPO = pr.COD_TIPO;
            prod.COD_UNIDADE = pr.COD_UNIDADE;
            prod.CLAS_FISC = pr.CLAS_FISC;
            prod.PESO_LIQ = pr.PESO_LIQ;
            prod.IPI = pr.IPI;
            prod.PRECO_CUSTO = pr.PRECO_CUSTO;
            prod.PRECO_VENDA = pr.PRECO_VENDA;
            prod.QTD_ESTIMADA = pr.QTD_ESTIMADA;
            prod.QTD_REAL = pr.QTD_REAL;
            prod.QTD_MINIMA = pr.QTD_MINIMA;
            // este registros vai ficar com o status de ALTERADO na memória
            // o método SaveChanges() aplica a alteração necessária
            ped.SaveChanges();
            erro = "";
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
        }
    }

    [WebMethod]
    public int InsereProduto(PRODUTOS pr, ref string erro)
    {
        try
        {
            // adicionar o produto recebido na tabela PRODUTOS do EDM
            ped.PRODUTOS.Add(pr);
            // vai ficar com o status de INSERIDO. SaveChanges() vai executar
            // um INSERT
            ped.SaveChanges();
            erro = "";
            return pr.ID_PRODUTO;
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
            return -1;
        }
    }

    [WebMethod]
    public void ExcluiProduto(int idProduto, ref string erro)
    {
        try
        {
            // consultar o produto que será excluído
            var prod = ped.PRODUTOS.Where(p => p.ID_PRODUTO == idProduto).First();
            // marcar este produto com EXCLUIDO
            ped.PRODUTOS.Remove(prod);
            // aplicar as alterações no banco
            ped.SaveChanges();
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
        }
    }

    [WebMethod]
    public USUARIOS DadosUsuario(string login, string senha,
                                 ref string erro )
    {
        try
        {
            // ler da tabela USUARIOS a linha que tenha USER_LOGIN igual ao digitado na tela
            // e USER_PWS igual a digitada na tela
            var usr = from u in ped.USUARIOS
                      where u.USER_LOGIN == login && u.USER_PWS == senha
                      select u;
            erro = "";

            if (usr.Count() > 0)
            {
                return new USUARIOS
                {
                    ID_USER = usr.First().ID_USER,
                    NIVEL = usr.First().NIVEL,
                    NOME = usr.First().NOME,
                    USER_LOGIN = usr.First().USER_LOGIN,
                    USER_PWS = usr.First().USER_PWS
                };
            }

            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            ex = getInnerException(ex);
            erro = ex.Message;
            return null;
        }
    }
}
