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
        // GET: Otchet
        List<Talon> tl = TalonServ.talonList;



        public  ViewResult Index()
        {
            return View(tl);
        }


    }
}