﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HendrixAccountant.Data.HendrixContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HENDRIXEntities : DbContext
    {
        public HENDRIXEntities()
            : base("name=HENDRIXEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCIONES> ACCIONES { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<ROL_ACCION> ROL_ACCION { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ENTRADAS> ENTRADAS { get; set; }
        public virtual DbSet<ENTRADAS_DETALLE> ENTRADAS_DETALLE { get; set; }
        public virtual DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public virtual DbSet<CATALOGOS> CATALOGOS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<ITEM_CATALOGO> ITEM_CATALOGO { get; set; }
        public virtual DbSet<PARAMETROS> PARAMETROS { get; set; }
        public virtual DbSet<CAJA> CAJA { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<FACTURA_DETALLE> FACTURA_DETALLE { get; set; }
        public virtual DbSet<MOVIMIENTOS_CAJA> MOVIMIENTOS_CAJA { get; set; }
        public virtual DbSet<SECUENCIAL> SECUENCIAL { get; set; }
        public virtual DbSet<VENTAS> VENTAS { get; set; }
    }
}