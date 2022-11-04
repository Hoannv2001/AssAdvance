using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssAdvance
{
    public class CartItems
    {
        private string idCT;
        private int quanlity;
        // private double totalPrice;
        // private List<BookItems> bookItems;
        private Cart cart;
        public string IdCT{get=>this.idCT; set=>idCT=value;}
        public Cart Cart{get=>this.cart; set=>this.cart = value;}
        public int Quantity{get=>this.quanlity; set=>this.quanlity=value;}
        public List<BookItems> BookList{get; set;}
        // public double TotalPrie{get=>this.totalPrice; set=>this.totalPrice=value;}
        public CartItems(int quanlity, string idCT ){
            this.Quantity = quanlity;
            // this.TotalPrie = totalPrice;
            // this.Cart.CartID  = c.CartID;
            this.IdCT = idCT;
            this.BookList= new List<BookItems>();
        }
        public override string ToString()
        {
            return $"{Quantity}\t";
        }
        public void addCartItems(BookItems bi){
            this.BookList.Add(bi);
        }
        public void infoCartItems(){
            Console.WriteLine($"Quanlity: {Quantity}");
            foreach (var item in BookList)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("Total Price:   "+item.Price*Quantity+"$");
            }

            
        }
    }
}