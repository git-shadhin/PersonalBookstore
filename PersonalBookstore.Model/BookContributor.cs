using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Model
{
    public class BookContributor
    {
        [Key]
        public int BookContributorID { get; set; }
        public int BookID { get; set; }
        public int ContributorID { get; set; }
        public int ContributorTypeID { get; set; }

        public virtual Book Book { get; set; }
        public virtual Contributor Contributor { get; set; }
        public virtual ContributorType ContributorType { get; set; }
    }
}
