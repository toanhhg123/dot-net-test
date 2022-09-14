using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeHuuToan_2001206939_LTW.Models
{
    public class Book
    {
        public Guid Guid { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public double Price { get; set; }
        
        public string Img { get; set; } = string.Empty;
    }

    public static class Books
    {
        public static List<Book> ListBook = new List<Book>();
    }
}
