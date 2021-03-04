using Assignment5.Models;
using Assignment5.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IAssignment5Repository _repository;

        public int pageSize = 5;

        public HomeController(ILogger<HomeController> logger, IAssignment5Repository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int page = 1)
        {
            return View(new BookListViewModel
            {
                //Sets up book list view model
                Books = _repository.Textbooks
                    .Where(p => category == null || p.Cat == category)
                    .OrderBy(p => p.BookId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),

                //Gets Paging Info, changes number of pages based on category
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalNumItems = category == null ? _repository.Textbooks.Count() : 
                        _repository.Textbooks.Where(x => x.Cat == category).Count()
                },
                CurrentCategory = category 
            }
            );
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
