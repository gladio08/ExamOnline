using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExamOnline.Controllers
{
    public class ParticipantsClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}