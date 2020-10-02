using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectrOcher.Controllers {
    public class OperatorController: Controller {
        IHubContext<ChatHub> hubContext;
        public OperatorController(IHubContext<ChatHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        

    }
}
