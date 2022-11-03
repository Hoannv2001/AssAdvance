using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssAdvance
{
    public class Cart
    {
        private string cartID;
        private string dateOrder;
        private CartItems cartItems;
        public string CartID{get=>this.cartID; set=>this.cartID=value;}
        public string DateOrder{get=>this.dateOrder; set=>this.dateOrder=value;}
        public CartItems CartItems{get=>this.cartItems; set=>this.cartItems=value;}
        public Cart(string id, string dateO, CartItems items){
            this.CartID=id;
            this.DateOrder = dateO;
            this.CartItems=items;
        }
        public override string ToString()
        {
            // var a = Cart.
            return $"{CartID}\t{DateOrder}\t"+CartItems.ToString();
        }
    }
}