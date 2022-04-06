using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using domain;
using Contracts;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogueController : ControllerBase
    {
        private readonly ICatalogue _catalogue;
        public CatalogueController(ICatalogue catalogue)
        {
            _catalogue = catalogue;
        }

        [HttpGet]
        // public ActionResult<IEnumerable<FilmDTO>> Get() // This is functionally equivalent to IActionResult
        // public async Task<IAsyncResult> Get() // or do it async
        public IActionResult Get()
        {
            var items = _catalogue.RetrieveCatalogue();
            return Ok(items);
        }

        [HttpGet("byTitle/{title}")]
        public IActionResult GetByTitle(string title)
        {
            var items = _catalogue.RetrieveTitle(title);
            return Ok(items);
        }

        [HttpGet("byYear/{year}")]
        public ActionResult<List<FilmDTO>> GetByYear(string year)
        {
            var items = _catalogue.RetrieveFilmsInYear(year);
            return Ok(items);
        }
    }



}