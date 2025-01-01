using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrastructure.Configuration
{
    public class AssuranceConfig : IEntityTypeConfiguration<Assurance>
    {
        public void Configure(EntityTypeBuilder<Assurance> builder)
        {
            builder.HasMany(h => h.Sinstre)
                    .WithOne(g => g.Assurance)
                    .HasForeignKey(j => j.AssuranceFk);
        }
    }
}
