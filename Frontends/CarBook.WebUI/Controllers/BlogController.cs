using CarBook.Aplication.Interfaces;
using CarBook.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
	public class BlogController: Controller
	{
		private readonly IBlogApiClient blogApiClient;

		// Constructor injection ile bağımlılığı alıyoruz
		public BlogController(IBlogApiClient blogApiClient)
		{
			this.blogApiClient = blogApiClient;
		}
		public async Task<IActionResult> Index()
		{
			ViewData["a"] = "Bloglar";
			ViewBag.b = "Yazarlarımızın Blogları";
			var blogs = await blogApiClient.GetAllBlogsWithWriterAsync();
			return View(blogs);
		}
		public async Task<IActionResult> BlogDetail(int id)
		{
			ViewData["a"] = "Bloglar";
			ViewBag.b = "Blog Detayı ve Yorumlar";
			ViewBag.blogId = id;

			return View(); // BlogDetail.cshtml view'ine gönder
		}
	}
	}

