using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Facebook;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShenkinStore.Models;


namespace ShenkinStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShenkinContext _context;

        public ProductsController(ShenkinContext context)
        {
            _context = context;
        }
        public IActionResult Color()
        {
            return View();
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {


            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Price,Colorr,productType,productBrand,gender,Description,Quantity,Metrial,ImageUrl")] Product product)
        {


            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                facebook(product.ProductName, product.Price, product.ImageUrl); // checking out git cmds
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Price,Colorr,productType,productBrand,gender,Description,Quantity,Metrial,ImageUrl")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }

        public async Task<IActionResult> BackPacks()
        {
            return View(await _context.Products.ToListAsync());
        }
        public async Task<IActionResult> SideBags()
        {
            return View(await _context.Products.ToListAsync());
        }
        public async Task<IActionResult> Wallets()
        {
            return View(await _context.Products.ToListAsync());
        }

        public void facebook(string ProductName, decimal ProductPrice, string ProductImage)  //after we add aflight we posted in facebool
        {
            dynamic messagePost = new ExpandoObject();
            messagePost.message = "New product is in the shop !";

            string acccessToken = "EAAFjnLLJDO0BAA3cpMU0Fko2Y6tJAf8LLZCWUsfZAoJ7D0MHfCoveQT3rTJBoljjqezgUpcOLKjHUy4MZAeZBsbEOsWvFwM351TLHlFNFIHyp6PMf3jh3ZAFgWu9wv88tZCSGn1ZC1GL75VHVZCnKV0aWhlNuiPwK9A87kkxFGWZC6QZDZD";
            FacebookClient appp = new FacebookClient(acccessToken); try
            {
                var postId = appp.Post("120440503196052" + "/feed", messagePost);
            }
            catch (FacebookOAuthException ex)
            { //handle oauth exception } catch (FacebookApiException ex) { //handle facebook exception
            }

        }
    } 
}
