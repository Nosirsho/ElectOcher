using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElectrOcher.Models;
using Microsoft.AspNetCore.SignalR;

namespace ElectrOcher.Controllers {
    public class HomeController : Controller {
        public static int nomerTalon = 0;
        

       
        IHubContext<ChatHub> hubContext;
        public HomeController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task Create(string connectionId)
        {
            nomerTalon++;
            Talon talon = new Talon {  NomerPP=nomerTalon.ToString(), AcceptFlag = false, TalonTime =DateTime.Now.ToLocalTime()  };

            TalonQueue.EnqueueTalon(talon);
            //Отправка талона на ИТ 
            await hubContext.Clients.AllExcept(connectionId).SendAsync("AddTalon", $"Талон № : {talon.NomerPP} Время регистрации: {talon.TalonTime} Статус: {talon.AcceptFlag}");
            //Получение талона
            await hubContext.Clients.Client(connectionId).SendAsync("Notify", $"Ваш Талон : " + nomerTalon);
            // Количество активных Талонов Оператор
            await hubContext.Clients.AllExcept(connectionId).SendAsync("TalonCount", $"Клиентов : {TalonQueue.GetTalonLength()}"  );
        }
    }
}

