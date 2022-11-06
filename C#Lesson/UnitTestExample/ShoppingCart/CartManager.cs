using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingCart
{
     public   class CartManager
    {
        private readonly List<CartItem> _cartItems;

        public CartManager(List<CartItem> cartItems)
        {
            _cartItems = cartItems;
        }
        public void Add(CartItem item)
        {
            _cartItems.Add(item);
        }
        public void Remove(int  productId)
        {
            var product = _cartItems.FirstOrDefault(t=>t.Product.ProductId==productId);
            _cartItems.Remove(product);
        }
        public List<CartItem> CartItems()
        {
             get{
                    return _cartItems;
                } 
        }
    }
}
