﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SigecaEntities : DbContext
    {
        public SigecaEntities()
            : base("name=SigecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<DocumentoAdjunto> DocumentoAdjunto { get; set; }
        public virtual DbSet<Expediente> Expediente { get; set; }
        public virtual DbSet<Implicado> Implicado { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<ProcedimientoLegal> ProcedimientoLegal { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Seguimiento> Seguimiento { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TablaGeneral> TablaGeneral { get; set; }
        public virtual DbSet<TipoDemanda> TipoDemanda { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
