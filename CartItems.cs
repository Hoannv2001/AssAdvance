using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssAdvance
{
    public class CartItems
    {
        private int quanlity;
        private BookItems bookItems;
        public int Quantity{get=>this.quanlity; set=>this.quanlity=value;}
        public BookItems BookItems{get=>this.bookItems;set=>this.bookItems=value;}
        public CartItems(int quanlity, BookItems bookItems){
            this.Quantity = quanlity;
            this.BookItems= bookItems;
        }
        // public double TotalOfPriceBook(string idBook){
        //     double result = 0;
        //     var searchBook = BookItems.FirstOrDefault(a=>a.Id.Equals(idBook));
        //     if(searchBook == null){
        //         return result =0;
        //     }else{
        //         result = Quantity*searchBook.Price;
        //         return result;
        //     }
        // }
        // public void addCartItems(BookItems bi){
        //     this.
        // }
        public override string ToString()
        {
            return $"{Quantity}\t{BookItems.BookName}\t{BookItems.Category}\t{BookItems.Price}";
        }
    }
}