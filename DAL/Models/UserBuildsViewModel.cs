using LoLHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserBuildsViewModel
    {
        public Champ champ { get; set; }
        public Pick pick { get; set; }
        public int like { get; set; }=0;
        public bool currentUserLike { get; set; } = false;
    }
}
