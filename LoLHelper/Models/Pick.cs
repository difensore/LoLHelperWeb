using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class Pick
    {
        public Pick()
        {
            Contrs = new HashSet<Contr>();
            UsersBuilds = new HashSet<UsersBuild>();
        }

        public int Id { get; set; }
        public string? Position { get; set; }
        public int Champ { get; set; }
        public int FirstSpell { get; set; }
        public int SecondSpell { get; set; }
        public int RunesBuild { get; set; }
        public int FirstStartedItem { get; set; }
        public int SecondStartedItem { get; set; }
        public int? ThirdStartedItem { get; set; }
        public int FirstMainItem { get; set; }
        public int SecondMainItem { get; set; }
        public int ThirdMainItem { get; set; }
        public int FivthMainItem { get; set; }
        public int? UserBuild { get; set; }

        public virtual Champ ChampNavigation { get; set; } = null!;
        public virtual Item FirstMainItemNavigation { get; set; } = null!;
        public virtual Spell FirstSpellNavigation { get; set; } = null!;
        public virtual Item FirstStartedItemNavigation { get; set; } = null!;
        public virtual RunesBuild RunesBuildNavigation { get; set; } = null!;
        public virtual Item SecondMainItemNavigation { get; set; } = null!;
        public virtual Spell SecondSpellNavigation { get; set; } = null!;
        public virtual Item SecondStartedItemNavigation { get; set; } = null!;
        public virtual Item ThirdMainItemNavigation { get; set; } = null!;
        public virtual Item? ThirdStartedItemNavigation { get; set; }
        public virtual ICollection<Contr> Contrs { get; set; }
        public virtual ICollection<UsersBuild> UsersBuilds { get; set; }
    }
}
