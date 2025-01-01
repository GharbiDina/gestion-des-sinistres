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
    public class ExpertiseConfiguration : IEntityTypeConfiguration<Expertise>
    {
        public void Configure(EntityTypeBuilder<Expertise> builder)
        {
            builder
.HasOne(r => r.Sinstre)
.WithMany(p => p.Expertises)
.HasForeignKey(r => r.SinstreKey);


            builder
                .HasOne(r => r.Expert)
                .WithMany(f => f.Expertises)
                .HasForeignKey(r => r.ExpertKey);
            builder.HasKey(r => new
            {
                r.DateExpertise,
                r.SinstreKey,
                r.ExpertKey
            });

        }
    }
}
