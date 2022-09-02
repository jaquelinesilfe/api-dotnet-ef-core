using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_Week.src.Models;
using Microsoft.EntityFrameworkCore;

namespace Dev_Week.src.Persistence
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {


        }
        public DbSet<Person> Persons { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>(tabela =>
            {
                tabela.HasKey(e => e.Id);
                tabela.HasMany(e => e.contracts).WithOne().HasForeignKey(c => c.PessoaId);
            });

            builder.Entity<Contract>(tabela =>
            {
                tabela.HasKey(e => e.Id);
            });

        }
    }
}