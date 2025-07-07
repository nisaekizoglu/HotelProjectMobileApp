using HotelProjectMobileApp.Api.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectMobileApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAllCategory()
    {
        var result = await _categoryRepository.GetAllAsync();
        return Ok(result);
    }
    //[HttpGet("GetAll/{status}")]
    //public async Task<IActionResult> GetAllCategory(bool status)
    //{
    //    var result = await _categoryRepository.GetAllAsync(x => (bool)x.StatusReservation == status); 
    //    return Ok(result);
    //}
    [HttpGet("GetAllSearch/{search}")]
    public async Task<IActionResult> GetAllCategory(string search)
    {
        search = search.ToLower();
        var result = await _categoryRepository.GetAllAsync(x => x.CategoryTitle.ToLower().Contains(search) || x.CategoryDescription.ToLower().Contains(search));
        return Ok(result);
    }
}
