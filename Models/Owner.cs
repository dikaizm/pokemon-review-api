﻿using System;
namespace pokemon_review_api.Models
{
	public class Owner
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Gym { get; set; }
		public Country Country { get; set; }
	}
}

