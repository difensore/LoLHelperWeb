using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLHelper.Models;
using Microsoft.AspNetCore.Identity;

namespace DAL.Models
{
    public class Like
    {

        public string Id { get; set; }
        public string UserId { get; set; }
        public int BuildId { get; set; }

        public virtual Pick Build { get; set; } = null!;
        public virtual IdentityUser User { get; set; } = null!;

    }
}
