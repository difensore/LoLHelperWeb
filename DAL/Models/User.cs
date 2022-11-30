using Microsoft.AspNetCore.Identity;
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

        public string Id { get; set; }

        public virtual ICollection<UsersBuild> UsersBuilds { get; set; }
    }
}
