using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Base;
using API.Models;
using API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerKeysController : BasesController<AnswerKey, AnswerKeyRepository>
    {
        private readonly AnswerKeyRepository _repository;
        public AnswerKeysController(AnswerKeyRepository answerKeyRepository) : base(answerKeyRepository)
        {
            _repository = answerKeyRepository;
        }

        [HttpGet("GetQuestions")]
        public IActionResult GetQuestions()
        {
            var result = _repository.AnswerKeys();
            return Ok(result);
        }

        [HttpGet("GetIdQuestion/{id}")]
        public IActionResult GetIdQuestion(int id)
        {
            var result = _repository.GetAnswerKeys(id);
            return Ok(result);
        }
    }
}