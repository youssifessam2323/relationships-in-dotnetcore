using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Relationships_in_efcore.Models;

namespace Relationships_in_efcore.Controllers
{
    [ApiController]
    [Route("weather/")]
    public class WeatherForecastController : ControllerBase
    {
        public ApplicationContext context { get; set; }
        
        
        public WeatherForecastController(ApplicationContext context)
        {
            this.context = context;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet("{commentId}")]
        public List<Comment> GetRepliesByComment(int commentId)
        {
           return context.Comments.Where(c => c.Id == commentId).Include(c => c.Replies).ToList();
                
        }
    }
}
