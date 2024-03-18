﻿using System.ComponentModel.DataAnnotations;

namespace mission11_dawson.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Publisher { get; set; }
        public required string ISBN { get; set; }
        public required string Classification { get; set; }
        public required string Category { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }

}

}
