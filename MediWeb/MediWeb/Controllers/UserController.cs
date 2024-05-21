using DataLayer;
using MediWeb.Model;
using MediWeb.Models;
using MediWeb.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MediWeb.Controllers
{
    public class UserController : Controller
    {
        public UnitOfWork _unitOfWork;
        public UserAccountService _userAccountService;    
        public PatientService _patientService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(UnitOfWork unitOfWork, UserAccountService userAccountService, PatientService patientService,
            UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) 
        { 
            _unitOfWork = unitOfWork;
            _userAccountService = userAccountService;
            _patientService = patientService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }

        // GET: UserController/Details/5
        public ActionResult Details(long id)
        {
            return View();
        }

        // GET: UserController/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: UserController/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel registerUserData)
        {
            if(!ModelState.IsValid)
                return View(registerUserData);
            var userAccount = await _userAccountService.AddUserAccountAsync(registerUserData.CreateUserAccount());
            await _patientService.AddPatientAsync(registerUserData.CreatePatient(userAccount));
            return View();
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(long id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(long id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
