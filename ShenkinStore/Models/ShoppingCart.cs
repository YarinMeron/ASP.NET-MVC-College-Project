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

       public static Dictionary<int, int> productsAmount = new Dictionary<int, int>();
        public static Dictionary<int, Product> idToProduct = new Dictionary<int, Product>();
        public static Dictionary<int, decimal> idToTotalSum = new Dictionary<int, decimal>();
  
        // Funcs
        // GetCart will return an object of shopping cart with the userId as ShoppingCartId
        //with "attechment"

        public static ShoppingCart GetCart(string UserId)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = UserId.ToString();
            return cart;
        }

        public Dictionary<int, decimal> GetProductTotal()
        {
            return idToTotalSum;
        }

        public Dictionary<int, int> GetAmount()
        {
            return productsAmount;
        }

        public void AddToCart(Product product,int amount)
        {

            if (!idToProduct.ContainsKey(product.ProductId))
            {
                idToProduct.Add(product.ProductId, product);
            }

    
           if (!productsAmount.ContainsKey(product.ProductId))
            {
                productsAmount.Add(product.ProductId, amount);
                idToTotalSum.Add(product.ProductId, product.Price * amount);
                
            }
            else
            {
                productsAmount[product.ProductId] = amount;
                idToTotalSum[product.ProductId] = product.Price*amount;
            }

        }

        public void RemoveFromCart(Product product)
        {

            idToProduct.Remove(product.ProductId);
            idToTotalSum.Remove(product.ProductId);
    

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
          return  idToProduct.Values.ToList();
       }
    public int getCount()
        {

            return this.GetCartItems().Count();
           
        }

        public decimal GetTotal()
        {

            decimal total = 0;
           
            total = idToTotalSum.Values.Sum();
          
            return total;
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



        public void IncreaseAmount(int id)
        {
            productsAmount[id]++;
            decimal newPrice = idToProduct[id].Price;
            idToTotalSum[id] += newPrice;
        }
        public void DecreaseAmount(int id)
        {
            productsAmount[id]--;
            decimal newPrice = idToProduct[id].Price;
            if (idToTotalSum[id] > 0)
            {
                idToTotalSum[id] -= newPrice;
            }
        }


        //Will auto create Transaction when you proceed to Payment
        public Transaction CreateTransaction(ShoppingCart shoppingcart)
        {
          
            Transaction transaction = new Transaction();
            transaction.Delivery = false;
            transaction.Paid = false;
            transaction.TransDate = DateTime.Now;
             transaction.Amount = shoppingcart.GetTotal();
           
            return transaction;
        }
        }
}
