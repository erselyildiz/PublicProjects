using System;
using System.Diagnostics;
using Business.Concreate;
using Entities.Abstract;
using Entities.Concreate.EntityFramework.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presantaion.Controllers
{
    [Authorize]
    public class BaseController<T> : Controller
    {
        public readonly UserManager<IdentityUser> _userManager;
        public readonly ILogger<T> _logger;
        public readonly Context _context;
        public MovieManager _movieManager;
        public Guid userId;

        public BaseController(ILogger<T> logger, Context context, UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
            this._context = context;
            this._logger = logger;
        }

        public Guid GetUserId()
        {
            return Guid.Parse(_userManager.GetUserId(User));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
