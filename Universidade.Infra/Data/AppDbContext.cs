using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Universidade.Domain.Models;

namespace Universidade.Infra.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : DbContext(options)
    {
        private readonly string _connectionString = GetConnectionString(configuration);

        private static string GetConnectionString(IConfiguration configuration)
        {
            var envConnection = Environment.GetEnvironmentVariable("DEFAULT_CONNECTION");
            var appsettingsConnection = configuration.GetConnectionString("DefaultConnection");

            if (!string.IsNullOrWhiteSpace(envConnection))
                return envConnection;

            if (!string.IsNullOrWhiteSpace(appsettingsConnection))
                return appsettingsConnection;

            throw new Exception("Não há ConnectionString.");
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Identidade> Identidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
