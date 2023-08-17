using Microsoft.AspNetCore.Mvc;
using FullStackNET.Data;
using Microsoft.EntityFrameworkCore;
using FullStackNET.Models;

namespace FullStackNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly FullStackDbContext _context;

        public EmployeeController(FullStackDbContext fullStackDbContext) {
            _context = fullStackDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
        {
            employeeRequest.Codigo = Guid.NewGuid();
            await _context.Employees.AddAsync(employeeRequest);
            await _context.SaveChangesAsync();
            
            return Ok(employeeRequest);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetAllEmployee([FromRoute] Guid id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Codigo == id);

            if (employee == null)
            {
                return NotFound();
            }
            else {
                return Ok(employee);
            }
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employee updateEmployee) { 
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null) { 
                return NotFound();
            }

            employee.Nombre= updateEmployee.Nombre;
            employee.Correo = updateEmployee.Correo;
            employee.Salario = updateEmployee.Salario;
            employee.Telefono = updateEmployee.Telefono;
            employee.Area = updateEmployee.Area;

            await _context.SaveChangesAsync();

            return Ok(employee);
        }


        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return Ok(employee);
        }

    }
}
