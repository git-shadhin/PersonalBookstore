using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.DTO
{
    public class ContributorDTO
    {
        public int ContributorID { get; set; }
        public string ContributorName { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }
    }
}
