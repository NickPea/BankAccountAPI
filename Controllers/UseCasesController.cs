using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankApi.ModelContext;
using BankApi.Models;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseCasesController : ControllerBase
    {
        private readonly BankApiContext _context;

        public UseCasesController(BankApiContext context)
        {
            _context = context;
        }

        // // GET: api/Transactions
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
        // {
        //     return await _context.Transactions.ToListAsync();
        // }

    }//end controller class
}//end namespace
