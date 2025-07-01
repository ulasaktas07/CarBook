using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Aplication.Interfaces.Services;
using CarBook.Dto.WriterDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/[controller]/[action]/{id?}")]
	public class WriterController(IWriterApiClient writerApiClient, IWriterService writerService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var writers = await writerApiClient.GetWritersAsync();
			return View(writers);
		}
		[HttpGet]
		public IActionResult CreateWriter()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateWriter(CreateWriterRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}
			var result = await writerService.CreateWriterAsync(request);
			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
		[HttpGet]
		public async Task<IActionResult> UpdateWriter(int id)
		{
			var writer = await writerApiClient.GetWriteForUpdateAsync(id);
			if (writer == null)
			{
				return NotFound();
			}
			return View(writer);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateWriter(UpdateWriterRequest request)
		{
			if (!ModelState.IsValid)
			{
				return View(request);
			}
			var result = await writerService.UpdateWriterAsync(request);
			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}

		public async Task<IActionResult> RemoveWriter(int id)
		{
			var result = await writerApiClient.DeleteWriterAsync(id);
			if (!result)
			{
				return NotFound();
			}
			return RedirectToAction(nameof(Index), new { area = "Admin" });
		}
	}
}
