using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(t => t.ProductType).WithMany()
                .HasForeignKey(t => t.ProductTypeId);
            
            builder.HasOne(t => t.ProductBrand).WithMany()
                .HasForeignKey(t => t.ProductBrandId);
        }
    }
}