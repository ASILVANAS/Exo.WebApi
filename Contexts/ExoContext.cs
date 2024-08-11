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
                OptionsBuilder.UseSqlServer("User ID=sa;Password=12345;Server=localhost\\SQLEXPRESS;Database=ExoApi;"+"Trusted_Connection=False");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
