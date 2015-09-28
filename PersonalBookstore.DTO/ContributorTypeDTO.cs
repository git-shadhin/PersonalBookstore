using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.DTO
{
    public class ContributorTypeDTO
    {
        public int ContributorTypeID { get; set; }
        public string ContributorTypeName { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public bool Deleted { get; set; }

    }
}
