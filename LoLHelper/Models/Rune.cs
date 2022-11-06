using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class Rune
    {
        public Rune()
        {
            RunesBuildFirstRuneNavigations = new HashSet<RunesBuild>();
            RunesBuildFirstRuneSNavigations = new HashSet<RunesBuild>();
            RunesBuildFourthRuneNavigations = new HashSet<RunesBuild>();
            RunesBuildSecondRuneNavigations = new HashSet<RunesBuild>();
            RunesBuildSecondRuneSNavigations = new HashSet<RunesBuild>();
            RunesBuildThirdRuneNavigations = new HashSet<RunesBuild>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int MainRune { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        public virtual MainRune MainRuneNavigation { get; set; } = null!;
        public virtual ICollection<RunesBuild> RunesBuildFirstRuneNavigations { get; set; }
        public virtual ICollection<RunesBuild> RunesBuildFirstRuneSNavigations { get; set; }
        public virtual ICollection<RunesBuild> RunesBuildFourthRuneNavigations { get; set; }
        public virtual ICollection<RunesBuild> RunesBuildSecondRuneNavigations { get; set; }
        public virtual ICollection<RunesBuild> RunesBuildSecondRuneSNavigations { get; set; }
        public virtual ICollection<RunesBuild> RunesBuildThirdRuneNavigations { get; set; }
    }
}
