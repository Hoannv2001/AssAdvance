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
        public void ViewCartItems(){
            int totalQuantity = 0;
            double totalPrice = 0;
            Console.WriteLine(ToString());
            var ci = CartItems.FindAll(a=>a.IdCT==CartID);
            foreach (var item in ci)
            {
                item.infoCartItems(); 
                totalQuantity+=item.Quantity;   
                totalPrice+=item.totalPrice();            
            }
            Console.WriteLine("----------***Bill***---------");
            Console.WriteLine($"Total Quantity:    {totalQuantity}"); 
            Console.WriteLine($"Total Price of Bill:   {totalPrice}$");
            Console.WriteLine($"-------***{DateOrder}***------");
            
        }
        public override string ToString()
        {
            return $"Cart ID: {CartID}\t Date Order: {DateOrder}\t";
        }
        public bool removeCartItem(string idCT){
            var removeCartItem = CartItems.FindAll(a=>a.IdCT == idCT);
            if(removeCartItem == null){
                Console.WriteLine($"ID book {removeCartItem} do not exits.");
                return false;
            }else{
                this.CartItems.RemoveAll(a=>a.IdCT == idCT);
                return true;
            }
        }
        public bool UpdateCartItem(int quanlity, string idBook, string idCT){
            var updateCartItem = CartItems.FindAll(a=>a.IdCT == idCT);
            if (updateCartItem==null)
            {
                Console.WriteLine($"ID Book {updateCartItem} do not exits.");
                return false;
            }else
            {
                foreach (var item in updateCartItem)
                {
                    item.Quantity = quanlity;
                    item.UpdateBook(idBook);
                }
                return true;
            }
        }
    }
}