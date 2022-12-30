using DAL.Models;
using LoLHelper.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LoLHelper.Services
{
    public class SortedPaginationBuilder: ISortedPaginationBuilder
    {
        public  SortedPaginationViewModel Create(SortState sortOrder, int page,IQueryable<UserBuildsViewModel> model )
        {
            int pageSize = 4;            
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    model = model.OrderByDescending(s => s.champ.Name);
                    break;
                case SortState.LikeAsc:
                    model = model.OrderBy(s => s.like);
                    break;
                case SortState.LikeDesc:
                    model = model.OrderByDescending(s => s.like);
                    break;
                default:
                    model = model.OrderBy(s => s.champ.Name);
                    break;
            }
            var count = model.Count();
            var items = model.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            SortedPaginationViewModel viewModel = new SortedPaginationViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                UserBuilds = items
            };
            return viewModel;
        }
    }
}
