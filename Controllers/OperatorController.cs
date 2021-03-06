﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElectrOcher.Models;
using Microsoft.AspNetCore.SignalR;

namespace ElectrOcher.Controllers
{
    public class OperatorController : Controller
    {
        


        IHubContext<ChatHub> hubContext;
        public OperatorController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task Call(string connectionId)
        {
            Talon talon=TalonQueue.PeekTalon();
            //Вызывается Талон в ИТ
            await hubContext.Clients.AllExcept(connectionId).SendAsync("CallTalon", talon.NomerPP);
            await hubContext.Clients.Client(connectionId).SendAsync("CallTalon", talon.NomerPP);
            
        }

        [HttpPost]
        public async Task Next(string connectionId)
        {

            Talon acceptTalon= TalonQueue.DequeueTalon();
            acceptTalon.AcceptFlag = true;
            acceptTalon.AcceptTime = DateTime.Now.ToLocalTime();
            
            TalonServ.talonList.Add(acceptTalon);
            
            
            int tWait = TalonQueue.GetTalonLength();
            int tAccept = TalonServ.talonList.Count;
            int tAll = tWait + tAccept;

            // Количество активных Талонов
            await hubContext.Clients.Client(connectionId).SendAsync("TalonCount", tWait.ToString(), tAccept.ToString(),tAll.ToString());
            await hubContext.Clients.AllExcept(connectionId).SendAsync("TalonCount", TalonQueue.GetTalonLength().ToString());
        }
    }
}

