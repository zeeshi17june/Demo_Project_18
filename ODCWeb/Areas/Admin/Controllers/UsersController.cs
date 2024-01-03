using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ODCWeb.DataAccess.Data;
using ODCWeb.Models;
using System.Security.Claims;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Immutable;
using ODCWeb.Utility;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace ODCWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class UsersController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext _db;

        public UsersController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ApplicationDbContext applicationDbContext)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            _db = applicationDbContext;

        }

        // GET: UsersController
        [HttpGet]
        public IActionResult Index()
        {
            var users = userManager.Users;
 
            return View(users);
        }
        public IActionResult Approval(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ApplicationUser userFromDb = _db.ApplicationUsers.FirstOrDefault(c => c.Id == id);
              
                if (userFromDb.Approved == false)
                {
                    userFromDb.Approved = true;
                }
                else
                {
                    userFromDb.Approved = false;
                }

                _db.Update(userFromDb);
                _db.SaveChanges();
/*                string RoleIdd = _db.UserRoles.Where(a => a.UserId == id).ToString();*/
                return View(userFromDb);
            }

        }

        public async Task<IActionResult> RoleChange(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ApplicationUser userFromDbb = await userManager.FindByIdAsync(id);
                if (userFromDbb.RoleName == SD.Role_Customer)
                {
                    userFromDbb.RoleName = SD.Role_Employee;
                    userFromDbb.RoleId = roleManager.Roles.FirstOrDefault(c => c.Name == SD.Role_Employee).Id;
                    _db.ChangeTracker.Clear();
                    await userManager.AddToRoleAsync(userFromDbb, SD.Role_Employee);
                    await userManager.RemoveFromRoleAsync(userFromDbb, SD.Role_Customer);
                }
                else
                {
                    userFromDbb.RoleName = SD.Role_Customer;
                    userFromDbb.RoleId = roleManager.Roles.FirstOrDefault(c => c.Name == SD.Role_Customer).Id;
                    await userManager.AddToRoleAsync(userFromDbb, SD.Role_Customer);
                    await userManager.RemoveFromRoleAsync(userFromDbb, SD.Role_Employee);
                }

                return View(userFromDbb);
            }

        }











        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
