using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class RoleAssignController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<AppRole> _roleManager;

		public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
		{
			_userManager = userManager;
			_roleManager = roleManager;
		}

		public IActionResult Index()
		{
			var values = _userManager.Users.ToList();
			return View(values);
		}
		[HttpGet]
		public async Task<IActionResult> AssignRole(int id)
		{
			var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
			TempData["userId"] = user.Id;
			var roles = _roleManager.Roles.ToList();
			var userRoles= await _userManager.GetRolesAsync(user);
			List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();
			foreach (var item in roles)
			{
				RoleAssignViewModel roleAssignViewModel = new RoleAssignViewModel
				{
					RoleID = item.Id,
					RoleName = item.Name,
					RoleExist = userRoles.Contains(item.Name)
				};
				roleAssignViewModels.Add(roleAssignViewModel);
			}
			return View(roleAssignViewModels);
		}
		[HttpPost]
		public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> roleAssignViewModels)
		{
			var user = _userManager.Users.FirstOrDefault(x => x.Id == (int)TempData["userId"]);
			if (user != null)
			{
				var userRoles = await _userManager.GetRolesAsync(user);
				foreach (var item in roleAssignViewModels)
				{
					if (item.RoleExist && !userRoles.Contains(item.RoleName))
					{
						await _userManager.AddToRoleAsync(user, item.RoleName);
					}
					else if (!item.RoleExist && userRoles.Contains(item.RoleName))
					{
						await _userManager.RemoveFromRoleAsync(user, item.RoleName);
					}
				}
			}
			return RedirectToAction("Index");
		}
	}
}
