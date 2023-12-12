using System;
namespace pokemon_review_api.Models
{
	public class Reviewer
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public ICollection<Review> Reviews { get; set; }
	}
}