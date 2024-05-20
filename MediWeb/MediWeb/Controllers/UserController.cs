using DataLayer;
using MediWeb.Model;
using MediWeb.Models;
using MediWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediWeb.Controllers
{
    public class UserController : Controller
    {
        public UnitOfWork _unitOfWork;
        public UserAccountService _userAccountService;    
        public PatientService _patientService;

        public UserController(UnitOfWork unitOfWork, UserAccountService userAccountService, PatientService patientService) 
        { 
            _unitOfWork = unitOfWork;
            _userAccountService = userAccountService;
            _patientService = patientService;
        }

        // GET: UserController
        public ActionResult Login()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginData)
        {
            return View();
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
