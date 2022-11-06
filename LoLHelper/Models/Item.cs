using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class Item
    {
        public Item()
        {
            PickFirstMainItemNavigations = new HashSet<Pick>();
            PickFirstStartedItemNavigations = new HashSet<Pick>();
            PickSecondMainItemNavigations = new HashSet<Pick>();
            PickSecondStartedItemNavigations = new HashSet<Pick>();
            PickThirdMainItemNavigations = new HashSet<Pick>();
            PickThirdStartedItemNavigations = new HashSet<Pick>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Pick> PickFirstMainItemNavigations { get; set; }
        public virtual ICollection<Pick> PickFirstStartedItemNavigations { get; set; }
        public virtual ICollection<Pick> PickSecondMainItemNavigations { get; set; }
        public virtual ICollection<Pick> PickSecondStartedItemNavigations { get; set; }
        public virtual ICollection<Pick> PickThirdMainItemNavigations { get; set; }
        public virtual ICollection<Pick> PickThirdStartedItemNavigations { get; set; }
    }
}
