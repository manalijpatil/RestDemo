using Microsoft.AspNetCore.Mvc;
using RestDemo.Model;
using RestDemo.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase

    {
        private readonly IBookService service;
        public BookController(IBookService service)
        {
            this.service = service;
        }
        // GET: api/<BookController>
        [HttpGet]
        [Route("GetBooks")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetBooks();
                return new ObjectResult(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // GET api/<BookController>/5
        [HttpGet]
        [Route("GetBookById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetBookById(id);
                if (model != null)
                {
                    return new ObjectResult(model);
                }
                else
                {
                    return StatusCode(StatusCodes.Status404NotFound);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,ex.Message);
            }
        }
        [HttpGet]
        [Route("GetBookByAuthor/{author}")]
        public IActionResult Get(string author)
        {
            try
            {
                var model = service.GetBookByAuthor(author);
                if(model != null)
                {
                    return new ObjectResult(model);
                }
                else
                {
                    return StatusCode(StatusCodes.Status204NoContent);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<BookController>
        [HttpPost]
        [Route("AddBook")]
        public IActionResult Post([FromBody] Book book)
        {
            try
            {
                var res = service.AddBook(book);
                if (res >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<BookController>/5
        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult Put([FromBody] Book book)
        {
            try
            {
                var res = service.UpdateBook(book);
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

        // DELETE api/<BookController>/5
        [HttpDelete]
        [Route("DeleteBook/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var res = service.DeleteBook(id);
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
