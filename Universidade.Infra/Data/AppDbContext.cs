using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Universidade.Domain.Models;

namespace Universidade.Infra.Data
{
    public partial class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _connectionString = GetConnectionString(configuration);
        }

        private string GetConnectionString(IConfiguration configuration)
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
