using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Driven.Application.User;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Driven.Web.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            this._userAppService = userAppService;
        }

        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}