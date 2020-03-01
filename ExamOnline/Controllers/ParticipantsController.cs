using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnline.Controllers
{
    public class ParticipantsController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public ParticipantsController()
        {
            client.BaseAddress = new Uri("https://localhost:44354/api/");
            client.DefaultRequestHeaders.Accept.Clear();

        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Users");
        }

        public JsonResult List()
        {
            IEnumerable<Participant> participants = null;
            var responseTask = client.GetAsync("Participants");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Participant>>();
                readTask.Wait();
                participants = readTask.Result;
            }
            else
            {
                participants = Enumerable.Empty<Participant>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = participants });
        }

        public JsonResult Create(Participant participants)
        {
            var myContent = JsonConvert.SerializeObject(participants);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("Participants/", byteContent).Result;
            return Json(new { data = affectedRow });
        }

        public JsonResult Edit(int id, Participant participants)
        {
            var myContent = JsonConvert.SerializeObject(participants);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var participant = client.PutAsync("AnswerKeys/" + id, byteContent).Result;
            return Json(new { data = participant });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("Participants/" + id).Result;
            var read = cek.Content.ReadAsAsync<Participant>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(Participant participants, int id)
        {
            var affectedRow = client.DeleteAsync("Participants/" + id).ToString();
            return Json(new { data = affectedRow });
        }
    }
}