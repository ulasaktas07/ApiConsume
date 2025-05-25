using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class RoleController : Controller
	{
		private readonly RoleManager<AppRole> _roleManager;

		public RoleController(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public IActionResult Index()
		{
			var values = _roleManager.Roles.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddRole()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddRole(AddRoleViewModel model)
		{
			AppRole appRole = new AppRole()
			{
				Name = model.RoleName
			};
			var result =await _roleManager.CreateAsync(appRole);
			if (result.Succeeded)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		public async Task<IActionResult> DeleteRole(int id)
		{
			var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			await _roleManager.DeleteAsync(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateRole(int id)
		{
			var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			UpdateRoleViewModel model = new UpdateRoleViewModel()
			{
				RoleID = values.Id,
				RoleName = values.Name
			};
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
		{
			var values = _roleManager.Roles.FirstOrDefault(x => x.Id == model.RoleID);
			values.Name = model.RoleName;
			await _roleManager.UpdateAsync(values);
			return RedirectToAction("Index");
		}
	}
}
