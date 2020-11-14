using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShenkinStore.Models;
using System.Data;
using System.Collections.Generic;
using System.Dynamic;

namespace ShenkinStore.Controllers
{
    public class UsersController : Controller
    {

        private readonly ShenkinContext _context;

        public UsersController(ShenkinContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
        public async Task<IActionResult> Search(string userName)
        {
            var query = from p in _context.Users
                        where p.UserName.Contains(userName)
                        select p;

            return PartialView(await query.ToListAsync());


        }


        public IActionResult Join()
        {
           

            List<User> userlist = new List<User>();
            userlist = _context.Users.ToList();
            List<Transaction> translist = new List<Transaction>();
            translist = _context.Transactions.ToList();
            //var query = userlist.Join(translist);
            //ViewBag.Query = query;
            var query = from e1 in userlist
                        join e2 in translist
                            on e1.UserId equals e2.User.UserId
                        select new
                        {
                            Name = e1.UserName,
                            Tran = e2.TransactionId
                        };

              ViewBag.Query2 = query;

            //dynamic model = new ExpandoObject();
            //model.Users = query.;
            //model.Transactions = db.Orders.ToList();
            return View();
        }
        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.Include(t => t.Transactions)

                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserName,Password,ConfirmedPassword,Email,Phone,userType")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,Password,ConfirmedPassword,Email,Phone,userType")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }


            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }

        public ActionResult Register()
        {
            User aUser = new User();
            return View(aUser);
        }
        [HttpPost]
        public ActionResult Register(User aUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Where(m => m.UserName == aUser.UserName).FirstOrDefault() == null)
                {
                    User objuser = new User();
                    objuser.CreatedOn = DateTime.Now;
                    objuser.Email = aUser.Email;
                    objuser.UserName = aUser.UserName;
                    objuser.Password = aUser.Password;
                    objuser.Phone = aUser.Phone;
                    objuser.userType = 0;
                    _context.Users.Add(objuser);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "User Name is already exists!");
                    return View();
                }
            }
            return View();

        }
        public ActionResult Login()
        {
            LoginModel objloginModel = new LoginModel();

            return View(objloginModel);
        }
        [HttpPost]
        public ActionResult Login(LoginModel objloginModel)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Where(m => m.UserName == objloginModel.UserName && m.Password == objloginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "User Name and Password are not Matching.");
                    return View();
                }
                else
                {
                    User un = _context.Users.Where(m => m.UserName == objloginModel.UserName).FirstOrDefault();
                    HttpContext.Session.SetString("UserName", un.UserName.ToString());
                    HttpContext.Session.SetInt32("UserID", (int)un.UserId);
                    HttpContext.Session.SetInt32("UserType", (int)un.userType);

                    return RedirectToAction("Index", "Products");
                }


            }
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");
            HttpContext.Session.Remove("UserType");
            HttpContext.Session.Remove("UserID");
            return RedirectToAction("Index", "Home");
        }


    }
}