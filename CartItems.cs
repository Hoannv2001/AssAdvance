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
        public double TotalOfPriceBook(){
            double result = 0;
                result = Quantity*BookItems.Price;
                return result;
            // }
        }
        public override string ToString()
        {
            return $"{Quantity}\t{BookItems.BookName}\t{BookItems.Category}\t{BookItems.Price}\t" + TotalOfPriceBook();
        }
    }
}