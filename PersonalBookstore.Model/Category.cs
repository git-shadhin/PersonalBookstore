using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(200)]
        public string CategoryName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }
        public virtual List<Book> Books { get; set; }

        public Category()
        {
            this.Books = new List<Book>();
        }
    }
}
