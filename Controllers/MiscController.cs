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
    public class MiscController : ControllerBase
    {
        private readonly BankApiContext _context;

        public MiscController(BankApiContext context)
        {
            _context = context;
        }














        [HttpGet("bankstatus")]
        public async Task<ActionResult> getPersonsCount()
        {
            BankStatus bankStatus = new BankStatus
            {
                PersonCount = await _context.Persons.CountAsync(),
                AccountCount = await _context.Accounts.CountAsync(),
                BankFinancialPosition = await _context.Accounts.SumAsync(a => a.Balance),
            };

            return Ok(bankStatus);
        }


        //helper
        private class BankStatus
        {
            public int PersonCount;
            public int AccountCount;
            public decimal BankFinancialPosition;

        }



    }//end controller
}//end namespace