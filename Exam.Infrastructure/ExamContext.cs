using ApplicationCore.Domain;
using Exam.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure
{
    public class ExamContext: DbContext
    {
        public DbSet<Assurance> Assurances { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<Sinstre> Sinstres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;

             Initial Catalog=Assurance;Integrated Security=true;
                  MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssuranceConfig());
                 modelBuilder.ApplyConfiguration(new ExpertiseConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
