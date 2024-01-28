using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CrystalMeds.Shared.Domain
{
	public class Prescription
	{
		public int PrescriptionId { get; set; }
		public string? PatientName { get; set; }
		public string? PrescriptionDescription { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }


	}
}
