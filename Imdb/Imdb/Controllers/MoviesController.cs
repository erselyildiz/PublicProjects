using Business.Concreate;
using Entities.Abstract;
using Entities.Concreate.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Presantaion.Controllers;
using System;
using System.Linq;

namespace Imdb.Controllers
{
    public class MoviesController : BaseController<MoviesController>
    {
        public MoviesController(ILogger<MoviesController> logger, Context context, UserManager<IdentityUser> userManager) : base(logger, context, userManager)
        {
            _movieManager = new MovieManager(context);
        }

        public IActionResult Index()
        {
            var result = _movieManager.Gets(x => x.isActive).ToList();
            return View(result);
        }

        public IActionResult CreateEdit(Guid? id)
        {
            ViewData["Genres"] = Enum.GetValues(typeof(Genre)).Cast<Genre>().Select(x => new SelectListItem() { Text = x.ToString(), Value = ((int)x).ToString() }).ToList();
            var model = id.HasValue ? _movieManager.Get(x => x.Id == id.Value) : new Movie() { AddedBy = GetUserId(), AddedDate = DateTime.Now, ReleaseDate = DateTime.Today };
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateEdit(Movie model)
        {
            if (model.Id == Guid.Empty)
            {
                _movieManager.Add(model);
            }
            else
            {
                model.EditedBy = GetUserId();
                model.EditedDate = DateTime.Now;
                _movieManager.Update(model);
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            _movieManager.Delete(id, GetUserId());
            return RedirectToAction(nameof(Index));
        }
    }
}
