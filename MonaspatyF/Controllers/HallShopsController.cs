using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonaspatyF.Models;
using MonaspatyF.Repository;

namespace MonaspatyF.Controllers
{
    public class HallShopsController : Controller
    {
        private readonly MonaspatyContext _context;
        private readonly HSORepository hSO; 

        public HallShopsController(MonaspatyContext context, HSORepository hSO)
        {
            _context = context;
            this.hSO = hSO;
        }

        // GET: HallShops
        public IActionResult Index()
        {
            return View(hSO.getHall());
        }
        public IActionResult IndexShop()
        {
            return View(hSO.getShop());
        }

        // GET: HallShops/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HallShop hallShop = hSO.getMyHOSById(id);
            if (hallShop == null)
            {
                return NotFound();
            }
            ViewBag.hallShop = hallShop;
            return PartialView();
        }
        
        private bool HallShopExists(int id)
        {
            return _context.HallShops.Any(e => e.Id == id);
        }
    }
}
