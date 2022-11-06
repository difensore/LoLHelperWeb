using LoLHelper.Interfaces;
using LoLHelper.Models;
using System.Linq;

namespace LoLHelper.Services
{
    public class DataProvider:IDataProvider
    {
        private readonly LolHelperContext db;
        public DataProvider(LolHelperContext context)
        {
            db = context;
        }
        public List<Champ> GetChamps()
        {
            var champ= db.Champs.ToList();
            return champ;
        }
    }
}
