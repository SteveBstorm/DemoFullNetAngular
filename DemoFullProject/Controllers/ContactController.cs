using LOCAL.Interface;
using LOCAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFullProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContactService _service;

        public ContactController(IContactService contactService)
        {
            _service = contactService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            return Ok(_service.GetOne(Id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contact c)
        {
            return Ok(_service.Insert(c));
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            return Ok(_service.Delete(Id));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Contact c)
        {
            _service.Update(c);
            return Ok();
        }
    }
}
