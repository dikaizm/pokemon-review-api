using System;
namespace pokemon_review_api.Models
{
	public class PokemonOwner
	{
		public int PokemonID { get; set; }
		public int OwnerID { get; set; }
		public Pokemon Pokemon { get; set; }
		public Owner Owner { get; set; }
	}
}

