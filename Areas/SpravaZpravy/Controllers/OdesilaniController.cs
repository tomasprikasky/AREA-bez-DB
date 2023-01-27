using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAD_WEB_1b.Areas.SpravaZpravy.Models;

namespace ZAD_WEB_1b.Areas.SpravaZpravy.Controllers
{
    [Area("SpravaZpravy")]
    public class OdesilaniController : Controller
    {
        public IActionResult Odeslani()
        {
            
            Modesilani modesilani = new Modesilani();
            return View(modesilani);
        }
        public IActionResult UspesneOdeslani()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Odeslani(Modesilani modesilani)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction(nameof(OdesilaniController.UspesneOdeslani));

            }

            return View(modesilani);

        }

        }
    }
