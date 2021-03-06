﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnline.Controllers
{
    public class RolesController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public RolesController()
        {
            client.BaseAddress = new Uri("https://localhost:44354/api/");
            client.DefaultRequestHeaders.Accept.Clear();

        }
        public IActionResult Index()
        {
            //var session = HttpContext.Session.GetString("Username");
            //if (session == null)
            //{
            //    return RedirectToAction("Index", "Users");
            //}
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Users");
        }

        public JsonResult List()
        {
            IEnumerable<Role> roles = null;
            var responseTask = client.GetAsync("Roles");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Role>>();
                readTask.Wait();
                roles = readTask.Result;
            }
            else
            {
                roles = Enumerable.Empty<Role>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = roles });
        }

        public JsonResult Create(Role role)
        {
            var myContent = JsonConvert.SerializeObject(role);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("Roles/Post", byteContent).Result;
            return Json(new { data = affectedRow, affectedRow.StatusCode }); //Bila menggunakan status code, jgn lupa dikembalikan status codenya
        }

        public JsonResult Edit(int id, Role role)
        {
            var myContent = JsonConvert.SerializeObject(role);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var departments = client.PutAsync("Roles/" + id, byteContent).Result;
            return Json(new { data = departments });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("Roles/" + id).Result;
            var read = cek.Content.ReadAsAsync<Role>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(Role role, int id)
        {
            var affectedRow = client.DeleteAsync("Roles/" + id).ToString();
            return Json(new { data = affectedRow });
        }


    }
}