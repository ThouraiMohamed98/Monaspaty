using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonaspatyF.Repository;
using MonaspatyF.Models;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace MonaspatyF.Controllers
{
    public class ControlPanelController : Controller
    {
        HSORepository HSO;
        MessageRepository MR;
        public ControlPanelController(HSORepository HSO , MessageRepository MR)
        {
            this.HSO = HSO;
            this.MR = MR;
        }

        public IActionResult Index()
        {
            ViewBag.HallShopOwner = HSO.getAllList();
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            HallShopOwner HS = HSO.getById(id);
            if(HS == null)
            {
                return NotFound();
            }
            return PartialView(HS);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(HallShopOwner ow)
        {
            try
            {
                HSO.Update(ow);
                return RedirectToAction("Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (HSO.getById(ow.Id)==null)
                {
                    return NotFound();
                }
                else
                {
                    return View(ow);
                }
            }
            //return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HallShopOwner ow)
        {
            if (ModelState.IsValid)
            {
                HSO.Add(ow);
                return RedirectToAction("Index");
            }
            return View(ow);
        }

        public IActionResult Details(int id)
        {
            return PartialView(HSO.getById(id));
        }

        public IActionResult Delete(int id)
        {
            HSO.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult MessageShow()
        {
            return View(MR.getMessage());
        }
        public IActionResult MessageDetails(int MessageId)
        {
            ViewBag.Message = MR.getById(MessageId);
            return PartialView();
        }
        public IActionResult DeleteMessage(int MessageId)
        {
            MR.Delete(MessageId);
            return RedirectToAction("MessageShow");
        }
    }
}
