using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class Contr
    {
        public int Id { get; set; }
        public int Champ { get; set; }
        public int Contr1 { get; set; }
        public string? Description { get; set; }

        public virtual Champ ChampNavigation { get; set; } = null!;
        public virtual Pick Contr1Navigation { get; set; } = null!;
    }
}
