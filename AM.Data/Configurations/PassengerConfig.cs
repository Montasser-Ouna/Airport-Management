using AM.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configurations
{
    internal class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.MyFullName,
                full =>
                {
                    full.Property(f => f.Firstname)
                    .HasMaxLength(30)
                    .HasColumnName("Name");
                    full.Property(f => f.Lastname)
                    .IsRequired();
                }
            );
            //tp5.1
            builder.HasDiscriminator<int>("IsTraveller")
               .HasValue<Passenger>(0)
                .HasValue<Staff>(2)
                .HasValue<Traveller>(1);

        }
    }
}
