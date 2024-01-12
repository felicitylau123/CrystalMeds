using CrystalMeds.Server.Data;
using CrystalMeds.Shared.Domain;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace CrystalMeds.Server.Configurations.Entities
{
	public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasData(
new Product
{
	ProductId = 1,
	ProductName = "Black",
	ProductPrice = 100,
	ProductCategory = "",
	CategoryId = 1
}
);


		}
	}
}
