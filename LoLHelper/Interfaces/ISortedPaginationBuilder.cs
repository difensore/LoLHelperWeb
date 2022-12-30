using DAL.Models;

namespace LoLHelper.Interfaces
{
    public interface ISortedPaginationBuilder
    {
        public SortedPaginationViewModel Create(SortState sortOrder, int page, IQueryable<UserBuildsViewModel> model);
    }
}
