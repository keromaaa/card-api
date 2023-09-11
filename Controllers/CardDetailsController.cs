using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using CardDetailsAPI.Models;
using CardDetailsAPI.Data;

namespace CardDetailsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CardDetailsController : ControllerBase
    {
        private readonly ApiContext _context;

        public CardDetailsController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult Create([FromBody] CardDetails card) 
        {
            var itemInDb = _context.CardDetails.Find(card.Id);

            if (itemInDb != null) 
                return new JsonResult(BadRequest("Item already exsists."));

            _context.CardDetails.Add(card);
            _context.SaveChanges();

            return new JsonResult(new
            {
                Data = card
            });
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.CardDetails.Find(id);

            if (result == null) return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.CardDetails.Find(id);

            if (result == null) return new JsonResult(NotFound());

            _context.CardDetails.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        // Get all
        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.CardDetails.ToList();

            return new JsonResult(new
            {
                Data = result
            });
        }
    }
}
