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
        // public double TotalBill(){
        //     double result = 0;
        //     foreach (var item in CartItems)
        //     {
        //         result += item.TotalOfPriceBook();
        //     }
        //     return result;
        // }
        public void AddOrderBook(CartItems ci){
            this.CartItems.Add(ci);
        }
        public override string ToString()
        {
            return $"{CartID}\t{DateOrder}\t";
        }
    }
}