using DAL.ViewModels;

namespace LoLHelper.Interfaces
{
    public interface IPickBuilder
    {
        public void CreateBuild(PickViewModel model);
        public void DeleteBuild(int id);
    }
}
