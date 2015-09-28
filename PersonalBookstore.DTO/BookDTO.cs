using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.DTO
{
    public class BookDTO
    {
        public int BookID { get; set; }
        public int BookTypeID { get; set; }
        public int PublisherID { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string ISBN_10 { get; set; }
        public string ISBN_13 { get; set; }
        public int Pages { get; set; }
        public string Dimensions { get; set; }
        public string Edition { get; set; }
        public DateTime? EditionDate { get; set; }
        public DateTime? FirstPublishedDate { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }
        
    }
}
