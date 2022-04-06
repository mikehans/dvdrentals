using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using domain;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogueController : ControllerBase
    {

        [HttpGet]
        // public ActionResult<IEnumerable<FilmDTO>> Get() // This is functionally equivalent to IActionResult
        // public async Task<IAsyncResult> Get() // or do it async
        public IActionResult Get()
        {
            var catalogue = new Catalogue();
            var items = catalogue.RetrieveCatalogue();
            return Ok(items);
        }

    }



}