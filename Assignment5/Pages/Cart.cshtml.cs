using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Assignment5.Models;
using Assignment5.Infrastructure;

namespace Assignment5.Pages
{
    public class CartModel : PageModel
    {
        private IAssignment5Repository repository;

        //Constructor
        public CartModel(IAssignment5Repository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long BookId, string returnUrl)
        {
            Textbook textbook = repository.Textbooks.FirstOrDefault(p => p.BookId == BookId);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(textbook, 1);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long BookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.textbook.BookId == BookId).textbook);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
