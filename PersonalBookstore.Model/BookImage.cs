using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class BookImage
    {
        [Key]
        public int BookImageID { get; set; }
        public int BookID { get; set; }
        public byte[] Image { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }

        public virtual Book Book { get; set; }
    }
}
