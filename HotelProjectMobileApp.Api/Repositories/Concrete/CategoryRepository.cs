using HotelProjectMobileApp.Api.Context;
using HotelProjectMobileApp.Api.Repositories.Abstract;
using HotelProjectMobileApp.Core.Models;

namespace HotelProjectMobileApp.Api.Repositories.Concrete;

public class CategoryRepository : GenericRepository<CategoryModel>, ICategoryRepository
{
    public CategoryRepository(HotelContext context) : base(context)
    {

    }
}
