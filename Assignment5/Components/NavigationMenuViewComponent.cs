using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IAssignment5Repository repository;

        public NavigationMenuViewComponent (IAssignment5Repository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            //Gets current category from URL
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            //Returns only the books included in the selected category
            return View(repository.Textbooks
                .Select(x => x.Cat)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
