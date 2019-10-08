using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
	public class iPetController : Controller
	{

		[HttpGet("/{petType}")]
		public ActionResult Index(string petType)
		{
			return View(petType);
		}

	}
}