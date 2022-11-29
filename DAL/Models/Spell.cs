using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class Spell
    {
        public Spell()
        {
            PickFirstSpellNavigations = new HashSet<Pick>();
            PickSecondSpellNavigations = new HashSet<Pick>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Cooldown { get; set; }
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;

        public virtual ICollection<Pick> PickFirstSpellNavigations { get; set; }
        public virtual ICollection<Pick> PickSecondSpellNavigations { get; set; }
    }
}
