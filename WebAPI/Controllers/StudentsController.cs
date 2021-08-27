using Core.Models;
using Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentRepository _studentRepo;

        public StudentsController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        // GET: api/<StudentsContorller>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _studentRepo.GetAll();
        }

        // GET api/<StudentsContorller>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentRepo.Get(id);
        }

        // POST api/<StudentsContorller>
        [HttpPost]
        public void Post([FromBody] Student newStudent)
        {
            _studentRepo.Create(newStudent);
        }

        // PUT api/<StudentsContorller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student newStudent)
        {
            _studentRepo.Update(id, newStudent);
        }

        // DELETE api/<StudentsContorller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentRepo.Delete(id);
        }
    }
}
