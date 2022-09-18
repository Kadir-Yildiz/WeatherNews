using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
	public class HomeViewModel
	{
		[Required]
		public string Place { get; set; }
		public decimal Temperature { get; set; }
	}
}
