using System;
using System.Net.Mime;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Route("authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService authorService;
        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AuthorDTO authorDTO)
        {
            var id = await this.authorService.Create(authorDTO);

            return Created($"{this.HttpContext.Request.Path}/{id}", null);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var authorDTO = await this.authorService.GetBy(id);

            return Ok(authorDTO);
        }
    }
}