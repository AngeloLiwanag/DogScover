using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DogScover.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DogScover.Controllers
{
    public class ItemController : Controller
    {
        private MyContext dbContext;
        public ItemController(MyContext context)
        {
            dbContext = context;
        }
//--------------------------Show All Products ------------------------------/
        [HttpGet("viewitems")]
        public IActionResult AllItems()
        {
            var allitems = dbContext.Items.Where(p => p.ItemId > 0).ToList();
            return View("AllItems", allitems);
        }
        

//-------------------------Show Specific Product CrowdFund------------------/

        [HttpGet("project/{id}")]
        public IActionResult ShowProject(int id)
        {
            int? SessionId = HttpContext.Session.GetInt32("SessionId");
            ViewBag.SessionId = SessionId;
            Item CurrentItem = dbContext.Items
            .Include(userwho =>userwho.CreatedProject)
            .Include(people=>people.Funders)
                .ThenInclude(items=>items.UsersFund)
            .FirstOrDefault(one=>one.ItemId==id);
            return View("ShowProject",CurrentItem);
        }

//------------------------Create a Project Page ----------------------------/
        [HttpGet("new/project")]
        public IActionResult ProjectForm()
        {
            int? SessionId = HttpContext.Session.GetInt32("SessionId");
            if(SessionId == null)
            {
                return RedirectToAction("LoginReg","Home");
            }
            else
            {
            return View("ProjectForm");
            }
        }

        [HttpPost("createproject")]
        public IActionResult CreateProject(Item NewProject)
        {
            int? SessionId = HttpContext.Session.GetInt32("SessionId");
            bool ItemInDb = dbContext.Items.Any(unique=>unique.Name==NewProject.Name);
            if(ModelState.IsValid)
            {
                if(ItemInDb == true)
                {
                    ModelState.AddModelError("Name","This Project Name Already Taken");
                    return RedirectToAction("ProjectForm");
                }
                else
                {
                    NewProject.UserId = (int)SessionId;
                    dbContext.Items.Add(NewProject);
                    dbContext.SaveChanges();
                    return RedirectToAction("HomePage","Home");
                }
            }
            else 
            {
                return View("ProjectForm");
            }
        }

// ---------------Update Project--------------------------------------/

// ---------------Delete Project--------------------------------------/

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Item DeleteItem = dbContext.Items.FirstOrDefault(own=>own.ItemId==id);
            dbContext.Items.Remove(DeleteItem);
            dbContext.SaveChanges();
            return RedirectToAction("HomePage","Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}