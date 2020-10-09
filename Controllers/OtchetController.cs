using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectrOcher.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectrOcher.Controllers
{
    public class OtchetController : Controller
    {
        List<Talon> tl = TalonServ.talonList;


        [HttpGet]
        public  ViewResult Index()
        {
            return View(tl);
        }

        [HttpPost]
        public ViewResult Index(DateTime sDate, DateTime eDate)
        {

            var filteredData = tl.Where(t => t.AcceptTime >= sDate && t.AcceptTime <= eDate);
            return View(filteredData);
            //return View(tl.Where(a => a.TalonTime >= sDate && a.TalonTime <= eDate));
        }

    }
}