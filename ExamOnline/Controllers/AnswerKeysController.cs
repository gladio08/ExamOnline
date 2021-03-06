﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using API.viewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamOnline.Controllers
{
    public class AnswerKeysController : Controller
    {
        readonly HttpClient client = new HttpClient();
        public AnswerKeysController()
        {
            client.BaseAddress = new Uri("https://localhost:44354/api/");
            client.DefaultRequestHeaders.Accept.Clear();

        }
        public IActionResult Index()
        {
            ViewBag.Question = GetQuestion();
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Users");
        }

        public JsonResult List()
        {
            IEnumerable<AnswerKeyVM> answerKeys = null;
            var responseTask = client.GetAsync("AnswerKeys/GetQuestions");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<AnswerKeyVM>>();
                readTask.Wait();
                answerKeys = readTask.Result;
            }
            else
            {
                answerKeys = Enumerable.Empty<AnswerKeyVM>();
                ModelState.AddModelError(String.Empty, "404 Not Found");
            }
            return Json(new { data = answerKeys });
        }

        public IList<Question> GetQuestion()
        {
            IList<Question> questions = null;
            var responTask = client.GetAsync("Questions");
            responTask.Wait();
            var result = responTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Question>>();
                readTask.Wait();
                questions = readTask.Result;
            }
            return questions;
        }

        public JsonResult Create(AnswerKey answerKeys)
        {
            var myContent = JsonConvert.SerializeObject(answerKeys);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var affectedRow = client.PostAsync("AnswerKeys/", byteContent).Result;
            return Json(new { data = affectedRow });
        }

        public JsonResult Edit(int id, AnswerKey answerKeys)
        {
            var myContent = JsonConvert.SerializeObject(answerKeys);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var answerKey = client.PutAsync("AnswerKeys/" + id, byteContent).Result;
            return Json(new { data = answerKey });
        }

        public JsonResult Details(int id)
        {
            var cek = client.GetAsync("AnswerKeys/" + id).Result;
            var read = cek.Content.ReadAsAsync<AnswerKey>().Result;
            return Json(new { data = read });
        }

        public JsonResult Delete(AnswerKey answerKeys, int id)
        {
            var affectedRow = client.DeleteAsync("AnswerKeys/" + id).ToString();
            return Json(new { data = affectedRow });
        }
    }
}