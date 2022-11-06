using System;
using System.Collections.Generic;

namespace LoLHelper.Models
{
    public partial class UsersBuild
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BuildId { get; set; }

        public virtual Pick Build { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
