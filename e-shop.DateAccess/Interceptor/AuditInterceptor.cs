using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace e_shop.Domain.Entities
{
    public class AuditInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            var entries = eventData.Context
                .ChangeTracker
                .Entries()
                .Where(r => r.Entity is IAuditable);

            foreach (var entityEntry in entries)
            {
                var entity = (IAuditable) entityEntry.Entity;
                if (entityEntry.State == EntityState.Added)
                {
                    entity.CreateAt = DateTime.UtcNow;
                    entity.CreatedBy = 1;
                }

                if (entityEntry.State == EntityState.Modified)
                {
                    entity.UpdateTime = DateTime.UtcNow;
                    entity.UpdatedBy = 1;
                }
            }

            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            var entries = eventData.Context.ChangeTracker
                .Entries()
                .Where(r => r.Entity is IAuditable);

            foreach (var e in entries)
            {
                var entity = (IAuditable) e.Entity;
                if (e.State == EntityState.Added)
                {
                    entity.CreateAt = DateTime.UtcNow;
                    entity.CreatedBy = 1;
                }

                if (e.State == EntityState.Modified)
                {
                    entity.UpdateTime = DateTime.UtcNow;
                    entity.UpdatedBy = 1;
                }
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
