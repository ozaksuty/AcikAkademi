using Data;
using Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repo
{
    public class UnitOfWork : IDisposable
    {
        private static readonly Context context = new Context();

        private GenericRepository<StudentModel> _studentRepository;

        public GenericRepository<StudentModel> StudentRepository
        {
            get
            {
                if (this._studentRepository == null)
                {
                    this._studentRepository = new GenericRepository<StudentModel>(context);
                }
                return _studentRepository;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UndoAll()
        {
            context.ChangeTracker.DetectChanges();

            var entries = context.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged).ToList();

            foreach (var dbEntityEntry in entries)
            {
                var entity = dbEntityEntry.Entity;

                if (entity == null) continue;

                if (dbEntityEntry.State == EntityState.Added)
                {
                    var set = context.Set(entity.GetType());
                    set.Remove(entity);
                }
                else if (dbEntityEntry.State == EntityState.Modified)
                {
                    dbEntityEntry.Reload();
                }
                else if (dbEntityEntry.State == EntityState.Deleted)
                    dbEntityEntry.State = EntityState.Modified;
            }
        }
    }
}