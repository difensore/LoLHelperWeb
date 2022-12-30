using DAL.Models;
using LoLHelper.Models;

namespace LoLHelper.Interfaces
{
    public interface ISortedPaginationBuilder
    {
        public SortedPaginationViewModel Create(SortState sortOrder, int page, IQueryable<UserBuildsViewModel> model);
        public SortedPaginationforChampViewModel CreatebyChamps(SortState sortOrder, int page, IQueryable<Champ> model);
    }
}
