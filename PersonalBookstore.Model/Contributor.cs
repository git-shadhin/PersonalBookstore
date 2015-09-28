using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class Contributor
    {
        [Key]
        public int ContributorID { get; set; }
        [MaxLength(200)]
        public string ContributorName { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }

        public virtual List<Book> Books { get; set; }
        public virtual List<ContributorType> ContributorTypes { get; set; }
        public Contributor()
        {
            this.ContributorTypes = new List<ContributorType>();
        }
    }
}
