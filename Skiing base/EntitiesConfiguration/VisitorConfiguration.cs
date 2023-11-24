using Microsoft.EntityFrameworkCore;
using Application.Entities.Visitor;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Skiing_base.EntitiesConfiguration
{
    public class VisitorConfiguration : IEntityTypeConfiguration<Visitor>
    {
        public void Configure(EntityTypeBuilder<Visitor> builder)
        {
            builder.HasKey(e => e.Id);

        }
    }
}
