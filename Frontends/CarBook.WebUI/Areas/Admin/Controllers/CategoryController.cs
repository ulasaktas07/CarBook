using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Services;
using CarBook.Dto.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class CategoryController(ICategoryApiClient categoryApiClient, ICategoryService categoryService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var categories = await categoryApiClient.GetCategoryAsync();
			return View(categories);
		}
		[HttpGet]
		public IActionResult CreateCategory()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryRequest request)
		{
			if (!ModelState.IsValid)
				return View(request);

			var result = await categoryService.CreateCategoryAsync(request);
			
			return RedirectToAction(nameof(Index), new {area="Admin"});

		}
		[HttpGet]
		public async Task<IActionResult> UpdateCategory(int id)
		{
			var category = await categoryApiClient.GetCategoryForUpdateAsync(id);
			if (category == null)
				return NotFound();
			return View(category);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryRequest request)
		{
			if (!ModelState.IsValid)
				return View(request);
			var result = await categoryService.UpdateCategoryAsync(request);
			
			return RedirectToAction(nameof(Index), new {area="Admin"});
		}
		public async Task<IActionResult> RemoveCategory(int id)
		{
			var result = await categoryApiClient.DeleteCategoryAsync(id);
			if (!result)
				return NotFound();
			return RedirectToAction(nameof(Index), new {area="Admin"});
		}
	}
}