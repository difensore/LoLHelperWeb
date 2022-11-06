using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class Champ
    {
        public Champ()
        {
            Contrs = new HashSet<Contr>();
            Picks = new HashSet<Pick>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Q { get; set; } = null!;
        public string W { get; set; } = null!;
        public string E { get; set; } = null!;
        public string R { get; set; } = null!;
        public string Passive { get; set; } = null!;
        public string? Image { get; set; }

        public virtual ICollection<Contr> Contrs { get; set; }
        public virtual ICollection<Pick> Picks { get; set; }
    }
}
