using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalMeds.Shared.Domain
{
	public class Promotion
	{
		public int PromotionId { get; set; }
		public string? PromotionName { get; set; }
		public float? PromotionAmount { get; set;}

	}
}
