﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.bd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class data1337Entities1 : DbContext
    {
        public data1337Entities1()
            : base("name=data1337Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avtobus> Avtobus { get; set; }
        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Dispetcher> Dispetcher { get; set; }
        public virtual DbSet<Marshrut> Marshrut { get; set; }
        public virtual DbSet<Perevozka> Perevozka { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<Voditel> Voditel { get; set; }
    }
}