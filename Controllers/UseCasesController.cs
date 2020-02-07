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

        /********************REGISTER A USER*****************/
        //REGISTER A NEW MEMBER (ADD PERSON, ACCOUNT, AND INITIAL TRANSACTION, UPDATE ACCOUNT BALANCE)

        /********************SIGN IN A USER************/
        //LOAD MEMBER DATA AND ALL ACCCOUNT (GET PERSON, GET ALL ACCOUNTS)

        /*******************USER INTERACTIONS*************/
        //CREATE NEW ACCOUNT (ADD ACCOUNT AND INITIAL TRANSACTION, UPDATE ACCOUNT BALANCE)
        //LOAD ACCOUNT DATA AND ALL TRANSACTIONS (GET ACCOUNT AND GET ALL TRANSACTIONS)
        //MAKE DEPOSIT (ADD TRANSACTION, UPDATE ACCOUNT BALANCE)
        //MAKE WITHDRAWL (ADD TRANSACTION, UPDATE ACCOUNT BALANCE)
        //TRANSFER TO ANOTHER ACCOUNT 
        //(
        //ADD WITHDRAWL TRANSACTION, UPDATE WITHDRAWL ACCOUNT
        //ADD DEPOSIT TRANSACTION, UPDATE DEPOSIT ACCOUNT
        //)

        /***************ADMIN ACTIONS********/
        //COUNT OF MEMBERS
        //COUNT OF ACCOUNTS
        //COUNT OF TRANSACTIONS
        //COUNT OF DEPOSITS/WITHDRAWLS
        //TOTAL BANK FINANCIAL POSITION (SUM OF ACCOUNT BALANCES)
        //LOAD ALL MEMBERS AND ACCOUNTS
        ///Lots more possible...

        /********ACCOUNT STATS*************/
        //TOTAL WIDTHDRAWLS AND DEPOSITS (TRANSACTION AMOUNTS ABOVE AND BELOW ZERO)



        // GET: api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }





    }//end controller class

}//end namespace
