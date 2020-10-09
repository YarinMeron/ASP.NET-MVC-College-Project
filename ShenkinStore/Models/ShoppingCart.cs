using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShenkinStore.Models
{
    public class ShoppingCart
    {
        // Database initiatl
        ShenkinContext db = new ShenkinContext();


        // Data for Recognation
        public string ShoppingCartId { get; set; }

        public const String CartSessionKey = "cartId";
      


        // Funcs


        // GetCart will return an object of shopping cart with the userId as ShoppingCartId
        //with "attechment"

        public static ShoppingCart GetCart(string UserId)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = UserId.ToString();
            return cart;
        }



        public int AddToCart(Product product)
        {

            if (product.sold == false && product.inCart == false)
            {
                var addedProduct = db.Products.Single(p => product.ProductId == p.ProductId);
                addedProduct.CartId = ShoppingCartId;
                addedProduct.inCart = true;
                db.SaveChanges();
                return 0;
            }
            else
            {
                return -1;
            }

        }

        public int RemoveFromCart(Product product)
        {
            if (product.inCart == true)
            {
                var addedProduct = db.Products.Single(p => product.ProductId == p.ProductId);
                addedProduct.CartId = null;
                addedProduct.inCart = false;
                db.SaveChanges();
                return 0;
            }
            else
                return -1;

        }

        public void emptyCart()
        {
            var cartItems = db.Products.Where(product => product.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
            {
                RemoveFromCart(cartItem);
            }
            db.SaveChanges();
        }

        public List<Product> GetCartItems()
        {
              return db.Products.Where(Product => Product.CartId == ShoppingCartId).ToList();
            
        }


        public int getCount()
        {
            int? count = (
                from product in db.Products
                where product.CartId == ShoppingCartId
                select product
                ).Count();

            // ?? - this operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.
            return count ?? -1;
        }

        //public decimal GetTotal()
        //{
        //    var list = new List<decimal>(from product in db.Products where product.CartId == ShoppingCartId && product.sold != true select product.Price).ToList();
        //    if (list != null)
        //    {
        //        // ?? - this operator is called the null-coalescing operator. It returns the left-hand operand if the operand is not null; otherwise it returns the right hand operand.
        //        return list.Sum();
        //    }
        //    else
        //        return 0;
        //}
        public decimal GetTotal()
        {
            //List<decimal> list = new List<decimal>(from product in db.Products .Where (product=>product.CartId== ShoppingCartId && product.sold != true )select product.Price).ToList();
            IEnumerable<decimal> list =
    from product in db.Products
    where product.CartId==ShoppingCartId
    orderby product descending
    select product.Price;
            if (list != null)
            {
                return list.Sum();
            }
            else
                return 0;


        }
        public decimal GetTotal2()
        {
            IEnumerable<decimal> list =
   from product in db.Products
   where product.CartId == ShoppingCartId
   orderby product descending
   select product.Price;
            if (list != null)
            {
                decimal sum = list.Sum();
                // return list.Sum();
                return sum;
            }
            else
                return 0;


        }


        // GetCartId will return CartId or will create one

        public string GetCartId(HttpContext context)
        {
            
            if (context.Session.GetString("CartSessionKey")==null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session.SetString("CartSessionKey", context.User.Identity.Name.ToString());
                }
                else
                {
                    // Guid - This class represents a globally unique identifier, Important!!!.
                    Guid tempCartId = Guid.NewGuid();
                    
                    context.Session.SetString("CartSessionKey", tempCartId.ToString());
                }
            }

            
            return context.Session.GetString("CartSessionKey");//maybe "tostring" is not nesscury
        }




        //Will auto create Transaction when you proceed to Payment
        public Transaction CreateTransaction(ShoppingCart shoppingcart)
        {
            //var transcation = new Transaction
            //{

            //    Delivery = false,
            //    Paid = false,
            //    TransDate = DateTime.Now,
            //   // Amount=0
            //    Amount = this.GetTotal(),
            //    // Cart = this
            //};
            Transaction transaction = new Transaction();
            transaction.Delivery = false;
            transaction.Paid = false;
            transaction.TransDate = DateTime.Now;
             transaction.Amount = shoppingcart.GetTotal2();
            //transaction.Amount = shoppingcart.GetTotal();

            // db.Transactions.Add(transcation);
            //  db.SaveChanges();
            return transaction;
        }
        }
}
