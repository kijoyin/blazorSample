using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackUsingBlazor.Shared;
using FullStackUsingBlazor.Shared.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackUsingBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        // GET: api/Expenses
        [HttpGet]
        public IEnumerable<Expense> Get()
        {
            return ExpenseCollection.Expenses;
        }

        // GET: api/Expenses/5
        [HttpGet("{id}", Name = "Get")]
        public Expense Get(int id)
        {
            return ExpenseCollection.Expenses.FirstOrDefault(e=>e.Id == id);
        }

        // POST: api/Expenses
        [HttpPost]
        public void Post([FromBody] Expense value)
        {
            ExpenseCollection.Expenses.Append(value);
        }

        // PUT: api/Expenses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
