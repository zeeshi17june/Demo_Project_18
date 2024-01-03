using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ODCWeb.DataAccess.Data;
using ODCWeb.Models;
using System;

namespace ODCWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext _db;
        public HomeController(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            this.userManager = userManager;
            _db = dbContext;
        }
        public IActionResult Index()
        {

            foreach (ApplicationUser person in _db.ApplicationUsers)
            {
                person.SubscriptionDaysLeft = ((int)(person.ExpiryDate - DateTime.Today).TotalDays);
                if (person.SubscriptionDaysLeft < 0 )
                {
                    person.SubscriptionStatus = false;
                }
                _db.Update(person);
                
            }
            _db.SaveChanges();
            return View();
        }
    }
}
