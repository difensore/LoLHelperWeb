using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; } 
        public SortState LikeSort { get; private set; }
        public SortState Current { get; private set; }
        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            LikeSort = sortOrder == SortState.LikeAsc ? SortState.LikeDesc : SortState.LikeAsc;
            Current = sortOrder;
        }
    }
}
