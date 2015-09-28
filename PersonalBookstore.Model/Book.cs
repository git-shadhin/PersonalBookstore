using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public int BookTypeID { get; set; }
        public int PublisherID { get; set; }
        [MaxLength(200)]
        public string BookName { get; set; }
        public string Description { get; set; }
        [MaxLength(10)]
        public string ISBN_10 { get; set; }
        [MaxLength(14)]
        public string ISBN_13 { get; set; }
        public int Pages { get; set; }
        [MaxLength(100)]
        public string Dimensions { get; set; }
        [MaxLength(100)]
        public string Edition { get; set; }
        public DateTime? EditionDate { get; set; }
        public DateTime? FirstPublishedDate { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }

        public virtual BookType BookType { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual List<BookImage> Images { get; set; }
        public virtual List<Contributor> Contributors { get; set; }
        public virtual List<Category> Categories { get; set; }
        public Book()
        {
            this.Images = new List<BookImage>();
            this.Contributors = new List<Contributor>();
            this.Categories = new List<Category>();
        }
    }
}
