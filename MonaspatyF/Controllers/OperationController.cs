using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonaspatyF.Repository;
using MonaspatyF.Models;

namespace MonaspatyF.Controllers
{
    public class OperationController : Controller
    {
        HSORepository HOS;
        public OperationController(HSORepository HOS)
        {
            this.HOS = HOS;
        }

        public IActionResult checkEmail(string email)
        {
            HallShopOwner hs = HOS.searchAboutEmail(email);
            if(hs == null)
            {
                return Json(true);
            }
            return Json(false);
        }

        public IActionResult checkSSN(string ssn)
        {
            HallShopOwner hs = HOS.searchAboutSSN(ssn);
            if(hs == null)
            {
                return Json(true);
            }
            return Json(false);
        }
    }
}
