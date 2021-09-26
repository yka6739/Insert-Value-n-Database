using Form1.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenresController:ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenresController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>>Post(Genre genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return genre.Id;
        }
    }
}
