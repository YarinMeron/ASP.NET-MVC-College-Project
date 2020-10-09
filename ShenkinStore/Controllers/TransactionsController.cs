using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShenkinStore.Models;
using ShenkinStore.ViewModels;

namespace ShenkinStore.Controllers
{
    public class TransactionsController : Controller
    {
        private ShenkinContext db = new ShenkinContext();

        public TransactionsController(ShenkinContext context)
        {
            db = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            return View(await db.Transactions.ToListAsync());
        }

       



        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await db.Transactions
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        // Using filter to allow access only to login users.
        //[Authorize] - TODO: uncomment before you go live
        public ActionResult Create()
        {
            var userID = HttpContext.Session.GetInt32("UserID");
            if (userID != null)
            {

                return View();
            }
            return RedirectToAction("Login", "Users");

        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionId,Delivery,Paid,TransDate,Amount")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
               // db.Add(transaction);
                db.Transactions.Add(transaction);
                await db.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Create");
            }
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await db.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionId,Delivery,Paid,TransDate,Amount")] Transaction transaction)
        {
            if (id != transaction.TransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(transaction);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TransactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await db.Transactions
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await db.Transactions.FindAsync(id);
            db.Transactions.Remove(transaction);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return db.Transactions.Any(e => e.TransactionId == id);
        }

        // GET: Transactions/AddressAndPayment/
        public ActionResult AddressAndPayment()
        {
            var userID = HttpContext.Session.GetInt32("UserID");
            if (userID != null)
            {

                User user = db.Users.Single(user => user.UserId == userID);

                if (user.Transactions == null)
                {
                    user.Transactions = new List<Transaction>();
                }



                if (user.Transactions.Count != 0 && user.Transactions.Last() != null && user.Transactions.Last().Paid == false)
                {
                    var transId = user.Transactions.Last().TransactionId;
                    user.Transactions.Remove(user.Transactions.Last());
                    db.Transactions.Remove(db.Transactions.Single(T => T.TransactionId == transId));
                }
                ShoppingCart shoppingCart = new ShoppingCart
                {
                    ShoppingCartId = HttpContext.Session.GetString("UserID").ToString() 
                //ShoppingCartId = user.UserId.ToString()
           

                };
                
                Transaction transaction = shoppingCart.CreateTransaction(shoppingCart);
                if (transaction.Amount != 0)
                {
                    //user.Transactions = new List<Transaction>();
                    user.Transactions.Add(transaction);
                   // shoppingCart.emptyCart();
                   
                    db.SaveChanges();
                    if (transaction != null)
                    {
                        TransactionViewModel transactionView = new TransactionViewModel
                        {
                            CartItems = db.Products.Where(product => product.CartId == user.UserId.ToString()).ToList(),
                            amount = transaction.Amount
                        };
                    
                
                        //return View(transactionView);    // We can redirect to wherever we want..
                        return RedirectToAction("emptyCart", "ShoppingCart");
                    }
                    else
                        return RedirectToAction("Index", "Transactions");
                }

            }
            return RedirectToAction("Index", "Products");

        }




    }
}
