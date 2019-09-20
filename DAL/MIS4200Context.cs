﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SandlingMIS4200.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SandlingMIS4200.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use

            // add the SetInitializer statement here

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,

           SandlingMIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code

        public DbSet<course> courses { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<instructor> instructors { get; set; }
        public DbSet<courseDetail> courseDetails { get; set; }


        // add this method - it will be used later

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}