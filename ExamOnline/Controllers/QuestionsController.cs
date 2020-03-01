using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Model;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnline.Controllers
{
    public class QuestionsController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public QuestionsController()
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
            IEnumerable<Question> questions = null;
            var responseTask = client.GetAsync("Questions");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Question>>();
                readTask.Wait();
                questions = readTask.Result;
            }
            else
            {
                questions = Enumerable.Empty<Question>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = questions });
        }

        public JsonResult Create(Question question)
        {
            var myContent = JsonConvert.SerializeObject(question);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("Questions/", byteContent).Result;
            return Json(new { data = affectedRow });
        }

        public JsonResult Edit(int id, Question question)
        {
            var myContent = JsonConvert.SerializeObject(question);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var questions = client.PutAsync("Questions/" + id, byteContent).Result;
            return Json(new { data = questions });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("Questions/" + id).Result;
            var read = cek.Content.ReadAsAsync<Question>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(Question question, int id)
        {
            var affectedRow = client.DeleteAsync("Questions/" + id).ToString();
            return Json(new { data = affectedRow });
        }
    }
}