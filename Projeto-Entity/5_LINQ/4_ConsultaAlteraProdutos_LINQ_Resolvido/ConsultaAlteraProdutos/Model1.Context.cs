﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PEDIDOSEntities : DbContext
    {
        public PEDIDOSEntities()
            : base("name=PEDIDOSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PRODUTOS> PRODUTOS { get; set; }
        public virtual DbSet<TIPOPRODUTO> TIPOPRODUTO { get; set; }
        public virtual DbSet<UNIDADES> UNIDADES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}
