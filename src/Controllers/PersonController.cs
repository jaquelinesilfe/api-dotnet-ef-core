using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dev_Week.src.Models;
using Dev_Week.src.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;


namespace Dev_Week.src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private DataBaseContext _context { get; set; }

        public PersonController(DataBaseContext context)
        {

            this._context = context;

        }

        [HttpGet]
        public List<Person> Get()
        {
            //Person pessoa = new Person("Jaqueline", 33, "1234567");
            //pessoa.contracts.Add(new Contract("abc123", 500.46));

            return _context.Persons.Include(p => p.contracts).ToList();

        }

        [HttpPost]
        public Person Post(Person pessoa)
        {
            _context.Persons.Add(pessoa);
            _context.SaveChanges();
            return pessoa;
        }

        [HttpPut("{id}")]
        public string Update([FromRoute] int id, [FromBody] Person pessoa)
        {
            _context.Persons.Update(pessoa);
            _context.SaveChanges();
            return "Dados do id" + id + " atualizados";
        }

        [HttpDelete("{id}")]
        public string Delete(int id, [FromBody] Person pessoa)
        {
            _context.Persons.Remove(pessoa);
            _context.SaveChanges();
            return "Deletados dados do id" + id;
        }
    }
}