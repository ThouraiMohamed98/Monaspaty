using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonaspatyF.Repository;
using MonaspatyF.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MonaspatyF.Controllers
{
    public class HallShopOwnerController : Controller
    {
        HSORepository HSO;
        cookies cookie;
        private readonly IWebHostEnvironment webHostEnvironment;

        public HallShopOwnerController(HSORepository HSO, cookies cookie, IWebHostEnvironment webHostEnvironment)
        {
            this.HSO = HSO;
            this.cookie = cookie;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Login()
        {
            if (cookie.GetCookie() != null)
            {
                int id = int.Parse(cookie.GetCookie());
                SetSession(id);
                return RedirectToAction("Profile");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password, string rememberme)
        {
            HallShopOwner ow = HSO.searchForLogin(Email, Password);
            if (ow != null)
            {
                //------------------------------Session-------------------------------------------------------
                SetSession(ow.Id);
                if (rememberme == "true")
                {
                    //---------------------------Cookie-------------------------------------------------------
                    cookie.setCooke(ow.Id.ToString(), 30);
                }

                if(ow.Id == 1)
                    return RedirectToAction("Index", "ControlPanel");
                else
                    return RedirectToAction("Profile");
            }
            else
            {
                ViewBag.Message = "UserName OR Password isn't Correct";
                return View();
            }
        }

        public IActionResult logOut()
        {
            SetSession(-1);
            cookie.deleteCookie();
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Create(HallShopOwner ow)
        {
            if (ModelState.IsValid)
            {
                HSO.Add(ow);
                SetSession(ow.Id);
                return RedirectToAction("Profile");
            }
            else
            {
                ModelState.AddModelError("","You have to fill all the Required fields");
                return View("Login");
            }
        }

        public IActionResult Profile()
        {
            int? id = HttpContext.Session.GetInt32("ownerId");
            if (id != null)
            {
                ViewBag.HallShop = HSO.getMyHOS(id);
                ViewBag.HallShopOwner = HSO.getById(id);
                return View();
            }
            else
                return RedirectToAction("Login");
        }

        //---------------------------------------------------------------------------------------------------------
        public ActionResult AddHS(int ownerid)
        {
            ViewBag.OwnerId = ownerid;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddHS(HallShop hs)
        {
            //if (ModelState.IsValid)
            //{

            string wwwRootPath = webHostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(hs.photo.FileName);
            string extension = Path.GetExtension(hs.photo.FileName);
            hs.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/attach/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                //await hs.photo.CopyToAsynch(fileStream);
                hs.photo.CopyTo(fileStream);
            }
            //hs.Image = hs.photo.FileName;
            //hs.photo.CopyTo(System.IO.File.Create($"wwwroot/attach/{hs.photo.FileName}"));
            
            HSO.saveHallOrShop(hs);
            SetSession(hs.OwnerId);
            return RedirectToAction("Profile");
            //}
            //else
            //{
            //    //return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddHS", HSO.getHAS()) });
            //    return Json(hs,JsonResult.Equals(false));
            //    //return PartialView("AddHS", hs);
            //}
        }

        public ActionResult EditHOS(int HOSid)
        {
            return PartialView(HSO.getMyHOSById(HOSid));
        }
        [HttpPost]
        public IActionResult EditHOS(HallShop hs)
        {
            //hs.Image = hs.photo.FileName;
            SetSession(hs.OwnerId);
            HSO.EditHallOrShop(hs);
            return RedirectToAction("Profile");
        }

        public IActionResult Delete(int id)
        {
            HallShop hs= HSO.getMyHOSById(id);
            if (System.IO.File.Exists($"wwwroot/attach/{hs.Image}"))
            {
                System.IO.File.Delete($"wwwroot/attach/{hs.Image}");
            }
            HSO.deleteHallOrShop(id);
            return RedirectToAction("Profile");
        }

        public void SetSession(int id)
        {
            HttpContext.Session.SetInt32("ownerId", id);

        }
    }
}