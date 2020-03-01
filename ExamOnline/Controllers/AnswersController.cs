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
    public class AnswersController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public AnswersController()
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
            IEnumerable<Answer> answers = null;
            var responseTask = client.GetAsync("Answers");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Answer>>();
                readTask.Wait();
                answers = readTask.Result;
            }
            else
            {
                answers = Enumerable.Empty<Answer>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = answers });
        }

        public JsonResult Create(Answer answer)
        {
            var myContent = JsonConvert.SerializeObject(answer);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("Answers/", byteContent).Result;
            return Json(new { data = affectedRow });
        }

        public JsonResult Edit(int id, Answer answer)
        {
            var myContent = JsonConvert.SerializeObject(answer);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var answers = client.PutAsync("Answers/" + id, byteContent).Result;
            return Json(new { data = answers });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("Answers/" + id).Result;
            var read = cek.Content.ReadAsAsync<AnswerKey>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(Answer answer, int id)
        {
            var affectedRow = client.DeleteAsync("Answers/" + id).ToString();
            return Json(new { data = affectedRow });
        }
    }
}