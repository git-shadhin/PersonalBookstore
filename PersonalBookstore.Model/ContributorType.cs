using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class ContributorType
    {
        [Key]
        public int ContributorTypeID { get; set; }
        [MaxLength(100)]
        public string ContributorTypeName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }

        public virtual List<Contributor> Contributors { get; set; }
        public ContributorType()
        {
            this.Contributors = new List<Contributor>();
        }
    }
}
