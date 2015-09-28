using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class Publisher
    {
        [Key]
        public int PublisherID { get; set; }
        [MaxLength(200)]
        public string PublisherName { get; set; }
        public string Description { get; set; }
        [MaxLength(200)]
        public string City { get; set; }
        [MaxLength(200)]
        public string State { get; set; }
        [MaxLength(200)]
        public string Country { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }

        public virtual List<Book> Books { get; set; }

        public Publisher()
        {
            this.Books = new List<Book>();
        }
    }
}
