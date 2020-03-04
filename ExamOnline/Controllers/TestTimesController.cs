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
    public class TestTimesController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public TestTimesController()
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
            IEnumerable<TestTime> testTimes = null;
            var responseTask = client.GetAsync("TestTimes");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<TestTime>>();
                readTask.Wait();
                testTimes = readTask.Result;
            }
            else
            {
                testTimes = Enumerable.Empty<TestTime>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = testTimes });
        }

        public JsonResult Create(TestTime testTime)
        {
            var myContent = JsonConvert.SerializeObject(testTime);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("TestTimes/", byteContent).Result;
            return Json(new { data = affectedRow });
        }

        public JsonResult Edit(int id, TestTime testTime)
        {
            var myContent = JsonConvert.SerializeObject(testTime);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var testTimes = client.PutAsync("TestTimes/" + id, byteContent).Result;
            return Json(new { data = testTimes });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("TestTimes/" + id).Result;
            var read = cek.Content.ReadAsAsync<TestTime>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(TestTime testTime, int id)
        {
            var affectedRow = client.DeleteAsync("TestTimes/" + id).ToString();
            return Json(new { data = affectedRow });
        }
    }
}