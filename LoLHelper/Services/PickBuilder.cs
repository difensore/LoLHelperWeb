using LoLHelper.Models;

namespace LoLHelper.Services
{
    public class PickBuilder
    {
        private readonly LolHelperContext db;
        public PickBuilder(LolHelperContext context)
        {
            db=context;
        }
        public void CreateBuild()
        {

        }
    }
}
