using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class RunesBuild
    {
        public RunesBuild()
        {
            Picks = new HashSet<Pick>();
        }

        public int Id { get; set; }
        public int MainrRune { get; set; }
        public int FirstRune { get; set; }
        public int SecondRune { get; set; }
        public int ThirdRune { get; set; }
        public int FourthRune { get; set; }
        public int SecondMainRune { get; set; }
        public int FirstRuneS { get; set; }
        public int SecondRuneS { get; set; }
        public int FirstExtraRune { get; set; }
        public int SecondExtraRune { get; set; }
        public int ThirdExtraRune { get; set; }

        public virtual ExtraRune FirstExtraRuneNavigation { get; set; } = null!;
        public virtual Rune FirstRuneNavigation { get; set; } = null!;
        public virtual Rune FirstRuneSNavigation { get; set; } = null!;
        public virtual Rune FourthRuneNavigation { get; set; } = null!;
        public virtual MainRune MainrRuneNavigation { get; set; } = null!;
        public virtual ExtraRune SecondExtraRuneNavigation { get; set; } = null!;
        public virtual MainRune SecondMainRuneNavigation { get; set; } = null!;
        public virtual Rune SecondRuneNavigation { get; set; } = null!;
        public virtual Rune SecondRuneSNavigation { get; set; } = null!;
        public virtual ExtraRune ThirdExtraRuneNavigation { get; set; } = null!;
        public virtual Rune ThirdRuneNavigation { get; set; } = null!;
        public virtual ICollection<Pick> Picks { get; set; }
    }
}
