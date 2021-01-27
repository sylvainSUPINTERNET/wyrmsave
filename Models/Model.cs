using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models.Schema;
using Microsoft.Extensions.Configuration;

namespace Models.Model
{

    public class WyrmSaveContext: DbContext 
    {

        public WyrmSaveContext() {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO for dev is OK 
            // TODO for dev / prod => using appsettings.json to define connection string
            
			optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=wyrmsave;User Id=root;Password=root;");
        }
        

        public DbSet<Profil> Profil { get; set; }

    }

    

}