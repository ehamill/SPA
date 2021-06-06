using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using MAW.Models;
using MAW.Data;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity;

namespace MAW.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<JsonResult> Get()
        { //testinggnsls dfjasdfa jf
            string ServerId = "SS1";
            City UserCity = await _context.City.Where(c => c.ServerId == ServerId).FirstOrDefaultAsync();
            if (UserCity == null) {
                UserCity = new City()
                {
                    CityId = 1,
                    CityName = "FirstCityName",
                    ServerId = "SS1",
                    UserId = "asdjfl2234"
                };
            }
            //var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return new JsonResult( new { city = UserCity } );
        }

        //[HttpGet]
        [HttpGet("{ServerId}")]
        public async Task<City> Get( string ServerId)
        {
            //string UserId = User.Identity.Name;
            City UserCity = await _context.City.Where(c => c.ServerId == ServerId).FirstOrDefaultAsync();
            //var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return UserCity;
        }

        [HttpGet]
        public async Task<JsonResult> Get()
        { //testinggnsls dfjasdfa jf
            string ServerId = "SS1";
            City UserCity = await _context.City.Where(c => c.ServerId == ServerId).FirstOrDefaultAsync();
            if (UserCity == null)
            {
                UserCity = new City()
                {
                    CityId = 1,
                    CityName = "FirstCityName",
                    ServerId = "SS1",
                    UserId = "asdjfl2234"
                };
            }
            //var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return new JsonResult(new { city = UserCity });
        }

        //[HttpGet]
        [HttpGet("{ServerId}")]
        public async Task<City> Get(string ServerId)
        {
            //string UserId = User.Identity.Name;
            City UserCity = await _context.City.Where(c => c.ServerId == ServerId).FirstOrDefaultAsync();
            //var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return UserCity;
        }
        [HttpGet]
        public async Task<JsonResult> Get()
        { //testinggnsls dfjasdfa jf
            string ServerId = "SS1";
            City UserCity = await _context.City.Where(c => c.ServerId == ServerId).FirstOrDefaultAsync();
            if (UserCity == null)
            {
                UserCity = new City()
                {
                    CityId = 1,
                    CityName = "FirstCityName",
                    ServerId = "SS1",
                    UserId = "asdjfl2234"
                };
            }
            //var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return new JsonResult(new { city = UserCity });
        }

        //[HttpGet]
        [HttpGet("{ServerId}")]
        public async Task<City> Get(string ServerId)
        {
            //string UserId = User.Identity.Name;
            City UserCity = await _context.City.Where(c => c.ServerId == ServerId).FirstOrDefaultAsync();
            //var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return UserCity;
        }
    }

    


}