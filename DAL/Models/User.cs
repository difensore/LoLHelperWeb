using System;
using System.Collections.Generic;


namespace LoLHelper.Models
{
    public partial class User
    {
        public User()
        {
            UsersBuilds = new HashSet<UsersBuild>();
        }

        public int Id { get; set; }

        public virtual ICollection<UsersBuild> UsersBuilds { get; set; }
    }
}
