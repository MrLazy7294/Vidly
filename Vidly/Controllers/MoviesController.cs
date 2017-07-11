﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context  = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie()
        //    {
        //        Name = "Shrek!"
        //    };
        //    var customers = new List<Customer>()
        //    {
        //      new Customer {  Name = "Siddharth", Id = 1 },
        //      new Customer {Name = "Agarwal" , Id = 2 }
        //    };
        //    var viewModel = new RandomMovieViewModel()
        //    {
        //        Customers = customers,
        //        Movie = movie
        //    };
        //    return View(viewModel);
        //    //return RedirectToAction("Index", "Home", new { page = 1 });
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("Id = " + id);
        //} 
        
        
        
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year + "/" + month);
        //}


        
        public ActionResult Index()
        {
            //var movies = GetMovies();
            var movies = _context.Movies.Include(m => m.Genre);
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            if (movies == null)
                return HttpNotFound();
            else
                return View(movies);
        }


    }
}