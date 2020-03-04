using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ExamOnline.viewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnline.Controllers
{
    public class UsersController : Controller
    {
        readonly HttpClient client = new HttpClient();
        readonly HttpClient local = new HttpClient();

        public UsersController()
        {
            client.BaseAddress = new Uri("http://192.168.128.233:1708/");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE1ODUyNzQwNDEsImlzcyI6ImJvb3RjYW1wcmVzb3VyY2VtYW5hZ2VtZW50IiwiYXVkIjoicmVhZGVycyJ9.YA-M_KN25FWmUuIS1bd9F5ioiRkVY8NCas1Bjma8kjQ");
            client.DefaultRequestHeaders.Accept.Clear();
            local.BaseAddress = new Uri("https://localhost:44359/Users/");

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserVM userVM)
        {
            var myContent = JsonConvert.SerializeObject(userVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var login = client.PostAsync("Login", byteContent).Result;
            if (login.IsSuccessStatusCode)
            {
                var content = login.Content.ReadAsStringAsync().Result.Replace("\"", "").Split("...");
                var token = "Bearer" + content[0];
                var username = content[1];
                HttpContext.Session.SetString("Username", username);
                HttpContext.Session.SetString("Token", token);
                return Json(new { data = login, StatusCode = 200 });
            }
            return Json(new { StatusCode = 400 });
        }

        [HttpPost]
        public async Task<ActionResult> ForgetPassword(UserVM userVM)
        {
            var myContent = JsonConvert.SerializeObject(userVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var token = client.PostAsync("Users/GenerateToken", byteContent).Result;

            if (token.IsSuccessStatusCode)
            {
                var content = token.Content.ReadAsAsync<UserVM>().Result;
                return Json(new { data = local.BaseAddress + "/" + content.Id, statusCode = 200 });
            }
            return Json(new { statusCode = 400 });
        }
    }
}