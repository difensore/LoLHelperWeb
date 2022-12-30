using DAL.Models;
using LoLHelper.Models;

namespace LoLHelper.Interfaces
{
    public interface IDataProvider
    {
        public IQueryable<Champ> GetChamps();
        public Task<PickManager> GetChampAsync(int champ,int entity);
        public List<Item> GetItems();
        public Task<Item> GetItemAsync(int id);
        public Task<int> GetContrPickAsync(string champ);
        public List<Spell> GetSpells();
        public List<MainRune> GetAllMainRunes();
        public List<Rune> GetAllRunes();
        public List<ExtraRune> GetAlExtraRunes();
        public IQueryable<UserBuildsViewModel> GetAllUserBuilds(string user, string forwhat);
        public void UpdateLike(string user, int build);

    }
}
