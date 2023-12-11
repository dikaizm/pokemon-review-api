﻿using System;
namespace pokemon_review_api.Models
{
	public class Review
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
		public Reviewer Reviewer { get; set; }
		public Pokemon Pokemon { get; set; }
	}
}

