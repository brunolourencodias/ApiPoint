using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Onecore_API.Data;
using Onecore_API.Models;

namespace Onecore_API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        public readonly EmployeeContext _EmployeeContext;

        public EmployeeController(EmployeeContext service)
        {
            this._EmployeeContext = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = _EmployeeContext.Employee.ToList();

            return Ok(model);

        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetId(int id)
        {

            try
            {
                Employee model = await _EmployeeContext.Employee.FirstOrDefaultAsync(x => x.EMP_ID == id);

                return Ok(model);

            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro banco de dados");
            }

        }


        [HttpPost]
        public void Post([FromBody]Employee employee)
        {
            
            _EmployeeContext.Employee.Add(employee);
            _EmployeeContext.SaveChanges();

        }

        [HttpPut("{Id}")]
        public void Update(int id, [FromBody]Employee employee)
        {
            if (id != employee.EMP_ID)
            {
                this.NoContent();
            }

            _EmployeeContext.Update(employee);
            _EmployeeContext.SaveChangesAsync();

            this.Ok();
        }

        [HttpDelete("{Id}")]
        public void Delete(int id, [FromBody]Employee employee)
        {
            var IdResult = GetId(id);

            if (IdResult != null)
            {
                _EmployeeContext.Remove(IdResult);
                _EmployeeContext.SaveChanges();
            }
        }
    }
}