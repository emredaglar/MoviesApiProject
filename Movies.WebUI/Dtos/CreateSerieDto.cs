﻿using Movies.EntityLayer.Concrete;

namespace Movies.WebUI.Dtos
{
    public class CreateSerieDto
    {
        public string SerieName { get; set; }
        public string? SerieImageUrl { get; set; }
        public string? SerieDescription { get; set; }
        public string? SerieScore { get; set; }
        public string? SerieCreatedDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
