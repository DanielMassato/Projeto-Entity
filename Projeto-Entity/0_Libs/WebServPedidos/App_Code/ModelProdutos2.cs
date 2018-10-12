﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class PRODUTOS
{
    public int ID_PRODUTO { get; set; }
    public string COD_PRODUTO { get; set; }
    public string DESCRICAO { get; set; }
    public Nullable<short> COD_UNIDADE { get; set; }
    public Nullable<short> COD_TIPO { get; set; }
    public Nullable<decimal> PRECO_CUSTO { get; set; }
    public Nullable<decimal> PRECO_VENDA { get; set; }
    public Nullable<int> QTD_ESTIMADA { get; set; }
    public Nullable<int> QTD_REAL { get; set; }
    public Nullable<int> QTD_MINIMA { get; set; }
    public string CLAS_FISC { get; set; }
    public Nullable<int> IPI { get; set; }
    public Nullable<decimal> PESO_LIQ { get; set; }

    public virtual TIPOPRODUTO TIPOPRODUTO { get; set; }
    public virtual UNIDADES UNIDADES { get; set; }
}

public partial class TIPOPRODUTO
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TIPOPRODUTO()
    {
        this.PRODUTOS = new PRODUTOS();
    }

    public short COD_TIPO { get; set; }
    public string TIPO { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual PRODUTOS PRODUTOS { get; set; }
}

public partial class UNIDADES
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public UNIDADES()
    {
        this.PRODUTOS = new PRODUTOS();
    }

    public short COD_UNIDADE { get; set; }
    public string UNIDADE { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual PRODUTOS PRODUTOS { get; set; }
}

public partial class USUARIOS
{
    public int ID_USER { get; set; }
    public string NOME { get; set; }
    public string USER_LOGIN { get; set; }
    public string USER_PWS { get; set; }
    public Nullable<short> NIVEL { get; set; }
}
