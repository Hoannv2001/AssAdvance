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
        private List<CartItems> cartItems;
        public string CartID{get=>this.cartID; set=>this.cartID=value;}
        public string DateOrder{get=>this.dateOrder; set=>this.dateOrder=value;}
        public List<CartItems> CartItems{get=>this.cartItems; set=>this.cartItems=value;}
        public Cart(string id, string dateO, List<CartItems> items){
            this.CartID=id;
            this.DateOrder = dateO;
            this.CartItems=items;
        }
        public void ViewCart(){
                Console.WriteLine(ToString());
                var ci = CartItems.FindAll(a=>a.IdCT==CartID);
                foreach (var item in ci)
                {
                    item.infoCartItems();
                    
                }
        }
        public override string ToString()
        {
            return $"Cart ID: {CartID}\t Date Order: {DateOrder}\t";
        }
    }
}