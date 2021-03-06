﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inzSNMWebForms.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class inzSNMEntities : DbContext
    {
        public inzSNMEntities()
            : base("name=inzSNMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Ankieta> Ankieta { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Bierze_udzial> Bierze_udzial { get; set; }
        public virtual DbSet<Dzieło> Dzieło { get; set; }
        public virtual DbSet<Epoka> Epoka { get; set; }
        public virtual DbSet<Glosujący> Glosujący { get; set; }
        public virtual DbSet<Kategoria> Kategoria { get; set; }
        public virtual DbSet<Muzyka> Muzyka { get; set; }
        public virtual DbSet<Narodowosc> Narodowosc { get; set; }
        public virtual DbSet<Ocena> Ocena { get; set; }
        public virtual DbSet<Plec> Plec { get; set; }
        public virtual DbSet<Statystyki> Statystyki { get; set; }
        public virtual DbSet<Technika> Technika { get; set; }
        public virtual DbSet<Wiek> Wiek { get; set; }
    
        public virtual int ADD_NEW_STAT(Nullable<int> iD_ANKIETY)
        {
            var iD_ANKIETYParameter = iD_ANKIETY.HasValue ?
                new ObjectParameter("ID_ANKIETY", iD_ANKIETY) :
                new ObjectParameter("ID_ANKIETY", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ADD_NEW_STAT", iD_ANKIETYParameter);
        }
    
        public virtual int DEACTIVATE_ANKIETA()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DEACTIVATE_ANKIETA");
        }
    
        public virtual int DEL_ANKIETY_AFTER_30_DAYS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DEL_ANKIETY_AFTER_30_DAYS");
        }
    }
}
