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
        public string IdCT{get=>this.idCT; set=>idCT=value;}
        public int Quantity{get=>this.quanlity; set=>this.quanlity=value;}
        public List<BookItems> BookList{get; set;}
        public CartItems(int quanlity, string idCT ){
            this.Quantity = quanlity;
            this.IdCT = idCT;
            this.BookList= new List<BookItems>();
        }
        public void addBookInCartItem(BookItems bi){
                this.BookList.Add(bi);
        }
        public bool UpdateBook(string idBook){
            var updatBook =  BookList.FindAll(a=>a.Id == idBook);
            if(updatBook == null){
                Console.WriteLine($"ID Book {updatBook} do not exits.");
                return false;
            }else{
                foreach (var item in updatBook)
                {
                    item.Id = idBook;
                }
                return true;
            }
        }
        public void infoCartItems(){
            Console.WriteLine($"Quanlity: {Quantity}");
            foreach (var item in BookList)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("Total Price:   "+item.Price*Quantity+"$");
            }            
        }
        public double totalPrice(){
            double totalPrice = 0;
            foreach (var item in BookList)
            {
                totalPrice = item.Price*Quantity;
            }
            return totalPrice;
        }
    }
}