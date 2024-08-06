using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {            
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if(!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder.UseSqlServer("User ID=sa;Password=admin;Server=localhost;Database=ExoApi;Trusted_Conection=False;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
