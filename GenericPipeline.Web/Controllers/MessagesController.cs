using System;
using System.Collections.Generic;
using GenericPipeline.Web.Models.Messages;
using Microsoft.AspNetCore.Mvc;

namespace GenericPipeline.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController:ControllerBase
    {
        [HttpPost]
        public void PushMessages([FromBody] List<Message> messages)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Message>> GetMessages()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<Message> GetMessage(string messageId)
        {
            throw new NotImplementedException();
        }
    }
}