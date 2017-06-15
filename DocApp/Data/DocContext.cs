using DocApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocApp.Data
{
    class DocContext : DbContext
    {
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var stateManager = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;

            var createdEntities = stateManager
                .GetObjectStateEntries(EntityState.Added)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var createdEntity in createdEntities)
            {
                createdEntity.CreatedAt = DateTime.Now;
                createdEntity.UpdatedAt = DateTime.Now;
            }

            var updatedEntities = stateManager
                .GetObjectStateEntries(EntityState.Modified)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var updatedEntity in updatedEntities)
            {
                updatedEntity.CreatedAt = DateTime.Now;
                updatedEntity.UpdatedAt = DateTime.Now;
            }

            return base.SaveChanges();
        }
    }
}
