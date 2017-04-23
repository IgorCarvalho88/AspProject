using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Igor.Models;

namespace Igor.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        // ActionResult é um tipo de return, pode tambbém ser ViewResult, PartialViewResult, ContentResult, JsonResult(return a sereliaze json) etc
        public ActionResult Random()
        {
            // instance of movie model
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //action when we navigate to movies, imagine that we return a view with a list of movies in a database
        // the question mark is for a nullable integer, in string we dont have to do anythin because in C sharp is a reference type and it´s nullable
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            // {0} -> significa o primeiro parametro
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }




}