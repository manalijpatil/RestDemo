using Microsoft.AspNetCore.Mvc;
using RestDemo.Model;
using RestDemo.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase

    {
        private readonly IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service;
        }
        // GET: api/<StudentController>
        [HttpGet]
        [Route("GetStudents")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetStudents();
                return new ObjectResult(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // GET api/<StudentController>/5
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetStudentById(id);
                if (model != null)
                {
                    return new ObjectResult(model);
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        [Route("AddStudent")]
        public IActionResult Post([FromBody] Student student)
        {
            try
            {
                var res = service.AddStudent(student);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut]
        [Route(" UpdateStudent")]
        public IActionResult Put([FromBody] Student student)
        {
            try
            {
                var res = service.UpdateStudent(student);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var res = service.DeleteStudent(id);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
