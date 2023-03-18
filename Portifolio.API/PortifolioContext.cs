using Microsoft.EntityFrameworkCore;
using Portifolio.API.Models;
using System;

namespace Portifolio.API
{
    public class PortifolioContext : DbContext
    {
        public PortifolioContext(DbContextOptions<PortifolioContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}