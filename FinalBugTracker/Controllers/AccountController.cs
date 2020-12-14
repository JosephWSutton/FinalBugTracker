using System;
using System.Threading.Tasks;
using FinalBugTracker.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

//namespace FinalBugTracker.Controllers
//{
//    [RequireHttps]
//    [Authorize]
//    public class AccountController : Controller
//    {
//        private readonly SignInManager<IdentityUser> _signInManager;
//        private readonly UserManager<IdentityUser> _userManager;

//        public AccountController(
//            UserManager<IdentityUser> userManager)
//        {
//            _userManager = userManager;
//        }

//        public AccountController(
//            SignInManager<IdentityUser> signInManager)
//        {
//            _signInManager = signInManager;
//        }

//        public IActionResult Register()
//        {
//            return View();
//        }

//        public IActionResult Login(string returnUrl)
//        {
//            return View();
//        }


//        [HttpPost]
//        public async Task<IActionResult> Login(string email, string password)
//        {
//            var user = await _userManager.FindByEmailAsync(email);

//            if(user != null)
//            {
//                //sign in
//                var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);

//                if (signInResult.Succeeded)
//                {
//                    return RedirectToAction("Index");
//                }
//            }

//            return RedirectToAction("Index");
//        }

//        [HttpPost]
//        public async Task<IActionResult> Register(string firstName, string lastName, string email, string password)
//        {
//            var user = new ApplicationUser
//            {
//                FirstName = firstName,
//                LastName = lastName,
//                Email = email,
//                PasswordHash = password
//            };

//            var result = await _userManager.CreateAsync(user);

//            if (result.Succeeded)
//            {
//                var signInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);

//                if (signInResult.Succeeded)
//                {
//                    return RedirectToAction("Index");
//                }
//            }

//            return RedirectToAction("Index");
//        }

//        public async Task<IActionResult> LogOut()
//        {
//            await _signInManager.SignOutAsync();
//            return RedirectToAction("Index");
//        }


//    }
//}
