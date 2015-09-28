using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class BookType
    {
        [Key]
        public int BookTypeID { get; set; }
        [MaxLength(100)]
        public string BookTypeName { get; set; }

        public virtual List<Book> Books { get; set; }

        public BookType()
        {
            this.Books = new List<Book>();
        }
    }
}
