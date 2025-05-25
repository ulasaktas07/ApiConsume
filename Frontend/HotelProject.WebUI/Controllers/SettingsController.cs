using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class SettingsController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public SettingsController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel userEditViewModel = new UserEditViewModel
			{
				Name = user.Name,
				Surname = user.Surname,
				Email = user.Email,
				Username = user.UserName
			};
			return View(userEditViewModel);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel model)
		{
			if (model.Password == model.ConfirmPassword)
			{
				var user = await _userManager.FindByNameAsync(User.Identity.Name);
				user.Name = model.Name;
				user.Surname = model.Surname;
				user.Email = model.Email;
				user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
				await _userManager.UpdateAsync(user);
				return RedirectToAction("Index", "Login");
			}
			return View();
		}
	}
}
