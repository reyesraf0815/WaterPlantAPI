using Microsoft.EntityFrameworkCore;
using PlantAPI.Models;
using System.Data.Entity;
namespace PlantAPI.Models
{
    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        public ApplicationDbContext() :
          base("PlantConnectionString")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<Plant> Plants { get; set; }
      
    }
}

       


    