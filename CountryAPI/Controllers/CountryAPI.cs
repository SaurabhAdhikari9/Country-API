using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CountryAPI.Models;
using EmployeeDataAccess;
using System.Collections.Generic;

namespace CountryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEnumerable<CountryItem> Get()
        {
            using (EmployeeDBEntites entites = new EmployeeDBEntites())
            {

            }
        }
    }
}
