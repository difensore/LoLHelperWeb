using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SortedPaginationViewModel
    {
        public List<UserBuildsViewModel> UserBuilds { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}
