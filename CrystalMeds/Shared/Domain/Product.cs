using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalMeds.Shared.Domain
{
	public class Product
	{
		public int ProductId { get; set; }
		public string? ProductName { get; set; }
		public float? ProductPrice { get; set; }
		public string? ProductCategory { get; set; }
		public int CategoryId { get; set; }
		public virtual Category? Category { get; set; }
	}
}
