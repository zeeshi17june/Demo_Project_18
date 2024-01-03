using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json.Linq;
using ODCWeb.DataAccess.Data;
using ODCWeb.DataAccess.Repository.IRepository;
using ODCWeb.Models;
using ODCWeb.Models.ViewModels;
using ODCWeb.Utility;
using System.Web;

namespace ODCWeb.Areas.Staff.Controllers
{
    [Area("Staff")]
    [Authorize(Roles = "Admin,Employee")]

    public class ODCProjectController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> userManager;

        public ODCProjectController(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _db = applicationDbContext;
            _unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {

          var projects = _unitOfWork.ODCProject.GetAll();
          return View(projects);
        }
        
        public async Task<IActionResult> UpsertAsync(int? id)      //*Combining Get controller for create and edit
        {
            ODCProject oDCProject = new()
            {
                
            };
            

            if (id == null || id ==0)   /*means it is Create view*/
            {
                return View(oDCProject);
            }
            else   //Update/Edit functionality
            {

                ODCProject oDCProject1 = _unitOfWork.ODCProject.Get(u => u.Id == id);
                
                return View(oDCProject1);
            }

        }
        [HttpPost]
        public IActionResult Upsert(ODCProject obj)  //*Combining Post controller for create and edit
        {
            if (ModelState.IsValid)
            {

                
                if (obj.Id == 0)
                {
                    
                    _unitOfWork.ODCProject.Add(obj);
                    _unitOfWork.save();
                    TempData["success"] = "Project created successfully";
                }
                else
                {
                    _unitOfWork.ODCProject.Update(obj);
                    _unitOfWork.save();
                    TempData["success"] = "Project updated successfully";
                    return RedirectToAction("Index", "ODCProject");
                }
                return RedirectToAction("Index", "ODCProject");
            }
            else
            {
                return View(obj);
            }
            
        }
        [HttpGet]
        public IActionResult InitiateFloor(int id)
        {
            Floor floor = new()
            {

            };
            ViewBag.ProjectID = id;

            ODCProject oDCProject = _unitOfWork.ODCProject.Get(u => u.Id == id);
            ViewBag.model1 = oDCProject;
            return View(floor);
        }
        [HttpPost]
        public IActionResult InitiateFloor(Floor obj)
        {

            if (ModelState.IsValid)
            {

                bool checker = false;
                /*                var asd = _unitOfWork.ODCProject.Get(u => u.FloorIds.FloorId == obj.FloorId);*/
                var asd = false;
                if (asd != null)
                {
                    checker = true;
                }
                if (checker == false)
                {

                    _unitOfWork.Floor.Add(obj);
                    _unitOfWork.save();
                    TempData["success"] = "Floor added successfully";
                    return RedirectToAction("Index", "ODCProject");
                }
                else
                {
                    TempData["error"] = "Floor already present";
                    return View(obj);
                }
            }
            else
            {
                return View(obj);
            }

        }
        public ActionResult ProjectDetails(int id)
        {
            return View();
        }

    }
}
