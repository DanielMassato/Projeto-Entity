//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultaAlteraProdutos
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIDADES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDADES()
        {
            this.PRODUTOS = new HashSet<PRODUTOS>();
        }
    
        public short COD_UNIDADE { get; set; }
        public string UNIDADE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTOS> PRODUTOS { get; set; }
    }
}
