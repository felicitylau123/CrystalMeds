using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalMeds.Shared.Domain
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string? CategoryName { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
        public virtual Product? Product { get; set; }

    }
}
