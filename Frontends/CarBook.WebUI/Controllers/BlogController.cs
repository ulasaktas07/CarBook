using CarBook.Aplication.Interfaces;
using CarBook.Aplication.Services;
using CarBook.Dto.AboutDtos;
using CarBook.Dto.CommentDtos;
using CarBook.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class BlogController(IBlogApiClient blogApiClient, ICommentService service) : Controller
	{
		public async Task<IActionResult> Index()
		{
			ViewData["a"] = "Bloglar";
			ViewBag.b = "Yazarlarımızın Blogları";
			var blogs = await blogApiClient.GetAllBlogsWithWriterAsync();
			return View(blogs);
		}
		public IActionResult BlogDetail(int id)
		{
			ViewData["a"] = "Bloglar";
			ViewBag.b = "Blog Detayı ve Yorumlar";
			ViewBag.blogId = id;

			return View(); // BlogDetail.cshtml view'ine gönder
		}

		[HttpGet]
		public PartialViewResult AddComment(int id)
		{
			ViewBag.blogId = id;
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> AddComment(CreateCommentRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}
			TempData["CommentSuccess"] = true;

			var result = await service.CreateCommentAsync(request);

			return RedirectToAction(nameof(Index));
		}

	}
}

