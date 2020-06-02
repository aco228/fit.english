using Blogifier.Core.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogifier.Controllers
{
	public class TestsController : Controller
	{
		private SignInManager<AppUser> _signInManager;
		private UserManager<AppUser> _userManager;

		public TestsController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
		{
			this._signInManager = signInManager;
			this._userManager = userManager;
		}

		[HttpGet("test/{username}/{password}")]
		public async Task<IActionResult> AddUser(string username, string password)
		{
			var ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
			var user = new AppUser { UserName = username, Email = username };
			var result = await _userManager.CreateAsync(user, password);
			if (result.Succeeded)
				return this.Content("Kreirano");
			else
				return this.Content("Nije Kreirano");

		}

	}
}
