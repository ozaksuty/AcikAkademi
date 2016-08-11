using Model;
using System.Data.Entity;

namespace Data
{
    public class Context : DbContext
    {
        public Context()
            : base("name=Connection")
        {
            //Database.SetInitializer<DbContext>(
            //    new CreateDatabaseIfNotExists<DbContext>());
        }
        public virtual DbSet<StudentModel> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}