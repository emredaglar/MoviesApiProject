﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DtoLayer.MovieDtos
{
	public class MovieWithCategoryDto
	{
		public int MovieId { get; set; }
		public string MovieName { get; set; }
		public string MovieImageUrl { get; set; }
		public string MovieDescription { get; set; }
		public string MovieScore { get; set; }
		public string MovieCreatedDate { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}
