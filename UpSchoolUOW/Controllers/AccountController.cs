using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOW_BusinessLayer.Abstract;
using UOW_DataAccessLayer.Concrete;
using UOW_EntityLayer.Concrete;
using UpSchoolUOW_PresentationLayer.Models;

namespace UpSchoolUOW_PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            Context c = new Context();
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);

            value1.AccountBalance -= p.Amount;
            value2.AccountBalance += p.Amount;
            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2,
            };
            _accountService.TMultipleUpdate(modifiedAccounts);
            return View();
        }
    }
}
