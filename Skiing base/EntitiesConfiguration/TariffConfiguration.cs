using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skiing_base.Entities.Tariff;

namespace Skiing_base.EntitiesConfiguration
{
    public class TariffConfiguration : IEntityTypeConfiguration<Tariff>
    {
        public void Configure(EntityTypeBuilder<Tariff> builder) 
        {
            builder.HasKey(e => e.Id);
        }

    }
}
