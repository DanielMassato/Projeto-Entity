using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProdutosConsulta
/// </summary>
public class ProdutosConsulta
{
    public ProdutosConsulta()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int ID_PRODUTO { get; set; }
    public string COD_PRODUTO { get; set; }
    public string DESCRICAO { get; set; }

    public string TIPO { get; set; }
    public string UNIDADE { get; set; }
    public Nullable<decimal> PRECO_VENDA { get; set; }
    public Nullable<int> QTD_REAL { get; set; }
    public Nullable<int> QTD_MINIMA { get; set; }


}