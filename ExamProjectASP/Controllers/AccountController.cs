using ExamProjectASP.Entities;
using ExamProjectASP.Helpers;
using ExamProjectASP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ExamProjectASP.Controllers
{
	public class AccountController : Controller
	{
		private UserManager<CustomIdentityUser> _userManager;
		private RoleManager<CustomIdentityRole> _roleManager;
		private SignInManager<CustomIdentityUser> _signInManager;
		private readonly IWebHostEnvironment _webHost;

		public AccountController(UserManager<CustomIdentityUser> userManager,
			RoleManager<CustomIdentityRole> roleManager,
			SignInManager<CustomIdentityUser> signInManager,
			IWebHostEnvironment webHost)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_signInManager = signInManager;
			_webHost = webHost;
		}

		// GET: AccountController
		public ActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult> Register(RegisterViewModel model)
		{
			//var helper = new ImageHelper(_webHost);
			//model.ImageUrl = await helper.SaveFile(model.File);
			CustomIdentityUser user = new CustomIdentityUser
			{
				Name = model.Name,
				Surname = model.Surname,
				Email = model.Email,
				ImageUrl = "~/images/profile.png",
				UserName = model.UserName,
				IsOnline = false
			};
			IdentityResult result = _userManager.CreateAsync(user, model.Password).Result;

			if (result.Succeeded)
			{
				if (!_roleManager.RoleExistsAsync("Admin").Result)
				{
					CustomIdentityRole role = new CustomIdentityRole
					{
						Name = "Admin"
					};

					IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
					if (!roleResult.Succeeded)
					{
						ModelState.AddModelError("", "We can not add the role");
						return View(model);
					}
				}

				_userManager.AddToRoleAsync(user, "Admin").Wait();
				return RedirectToAction("Login", "Account");
			}
			return View(model);
		}



		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult> Login(LoginViewModel model)
		{
			//if (ModelState.IsValid)
			//{
			var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
			if (result.Succeeded)
			{
				return RedirectToAction("Friends", "Home");
			}
			ModelState.AddModelError("", "Invalid Login");
			//}
			return View(model);
		}


		public IActionResult LogOut()
		{
			_signInManager.SignOutAsync().Wait();
			return RedirectToAction("Login", "Account");
		}
	}
}
