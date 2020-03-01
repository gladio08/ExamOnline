﻿using System;
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
        public AnswerKeysController(AnswerKeyRepository answerKeyRepository) : base(answerKeyRepository)
        {
        }
    }
}