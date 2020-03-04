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
    public class ChoicesController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public ChoicesController()
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
            IEnumerable<Choice> choices = null;
            var responseTask = client.GetAsync("Choices");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Choice>>();
                readTask.Wait();
                choices = readTask.Result;
            }
            else
            {
                choices = Enumerable.Empty<Choice>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = choices });
        }

        public JsonResult Create(Choice choice)
        {
            var myContent = JsonConvert.SerializeObject(choice);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("Choices/", byteContent).Result;
            return Json(new { data = affectedRow });
        }

        public JsonResult Edit(int id, Choice choice)
        {
            var myContent = JsonConvert.SerializeObject(choice);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var choices = client.PutAsync("Choices/" + id, byteContent).Result;
            return Json(new { data = choices });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("Choices/" + id).Result;
            var read = cek.Content.ReadAsAsync<Choice>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(Choice choice, int id)
        {
            var affectedRow = client.DeleteAsync("Choices/" + id).ToString();
            return Json(new { data = affectedRow });
        }
    }
}