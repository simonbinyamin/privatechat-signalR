using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalR.Chat;

namespace SignalR.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index(string _id) => View((object)_id);
       
    }
}