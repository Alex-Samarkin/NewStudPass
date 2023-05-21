// NewStudPass
// NewStudPass
// DataContext.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 1:33 22 05 2023

using System.Data.Entity;
using System.Reflection;

namespace NewStudPass
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<InternetSource> InternetSources { get; set; }

        public DataContext() : base("NewStudPassDB")
        {
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
        }
    }
}