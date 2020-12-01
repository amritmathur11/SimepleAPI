using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        [HttpGet]
        public int Get()

        {
            Random random = new Random();
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            return shift;
        }
        [HttpPost]
        public double Post()

        {

            Random random = new Random();

            double flt = random.NextDouble();
            return flt;
        }
        [HttpPut]
        public string Put()

        {

            return "Thank you for the new number!";

        }
        [HttpDelete]
        public char Delete()

        {

            Random random = new Random();
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            char letter = Convert.ToChar(shift + 65);
            return letter;

        }
        [HttpPatch]
        public DateTime Patch()

        {

            DateTime localDate = DateTime.Now;

            return localDate;

        }
        [HttpOptions]
        public String Options()
        {
            return "GET: Return a Random Integer" + "POST: Return a Random Double" + "PUT: Return a String";
        }
    }
}