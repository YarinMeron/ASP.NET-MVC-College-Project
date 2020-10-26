using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShenkinStore.Models;
using ShenkinStore.ViewModels;

namespace ShenkinStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        ShenkinContext db = new ShenkinContext();

        public string shoppingCartId { get; set; }


        // GET: ShoppingCart

        public ActionResult Index()
        {
  
            var userID = HttpContext.Session.GetString("UserID");
            if (userID != null)
            {
                var cart = ShoppingCart.GetCart(userID.ToString());

                var viewModel = new ShoppingCartViewModel
                {
                    CartItems = cart.GetCartItems(),
                    CartTotal = cart.GetTotal()
                };
                return View(viewModel);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
      

        // GET: ShoppingCart/AddToCart/id
        public ActionResult AddToCart(int id,int x)
        {
            var userID = HttpContext.Session.GetString("UserID");
            if (userID != null)
            {
                var addedProduct = db.Products.Single(product => product.ProductId == id);
                var cart = ShoppingCart.GetCart(userID.ToString());
                for (int i = 0; i < x; i++)
                {

                cart.AddToCart(addedProduct);
                }
                

                

                return RedirectToAction("Index", "ShoppingCart");
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
        }

        // GET: ShoppingCart/RemoveFromCart/id
        public ActionResult RemoveFromCart(int id)
        {
            var userID = HttpContext.Session.GetString("UserID");
            if (userID != null)
            {
                var cart = ShoppingCart.GetCart(userID.ToString());
                Product product = db.Products.FirstOrDefault(item => item.ProductId == id);
                
                cart.RemoveFromCart(product);
                return RedirectToAction("Index", "ShoppingCart");
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }

        }

        public ActionResult emptyCart()
        {
            var userID = HttpContext.Session.GetString("UserID");
            if (userID != null)
            {

                var cart = ShoppingCart.GetCart(userID.ToString());
                var cartItems = db.Products.Where(product => product.CartId == cart.ShoppingCartId);
                foreach (var cartItem in cartItems)
                {

                    cart.RemoveFromCart(cartItem);
                }
                db.SaveChanges();



                return RedirectToAction("Index", "ShoppingCart");
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
        }





        /* Maybe We will need it on Future
         * For [ChildActionOnly]
         * See https://stackoverflow.com/questions/10253769/using-childactiononly-in-mvc
         */
        //     [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var userID = HttpContext.Session.GetString("UserID");
            if (userID != null)
            {
                var cart = ShoppingCart.GetCart(userID.ToString());

                ViewData["CartCount"] = cart.getCount();

                return PartialView("CartSummary");
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
        }


        

        //Kind of Grabge Collector, unmanneged
        //credit to:  https://stackoverflow.com/questions/10134406/why-is-there-need-for-an-explicit-dispose-method-in-asp-net-mvc-controllers-c
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
