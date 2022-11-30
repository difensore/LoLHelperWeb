using LoLHelper.Interfaces;
using LoLHelper.Models;
using System.Security.Principal;

namespace LoLHelper.Services
{
    public class IdentityProvider:IIdentityProvider
    {
        private readonly LolHelperContext db;
        public IdentityProvider(LolHelperContext context)
        {
            db = context;
        }
        public int CreateUser()
        {            
            return 0;
        }
    }
}
