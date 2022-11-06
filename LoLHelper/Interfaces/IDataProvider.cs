using LoLHelper.Models;

namespace LoLHelper.Interfaces
{
    public interface IDataProvider
    {
        public List<Champ> GetChamps();
    }
}
