using LoLHelper.Models;

namespace LoLHelper.Interfaces
{
    public interface IDataProvider
    {
        public List<Champ> GetChamps();
        public Task<PickManager> GetChampAsync(int champ);
    }
}
