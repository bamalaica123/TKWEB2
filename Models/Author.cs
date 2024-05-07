﻿using System.ComponentModel.DataAnnotations;

namespace TKW2.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Book_Author> Book_Authors { get; set; }

    }
}
