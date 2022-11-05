namespace AssAdvance
{
    public class customer:User,ISearchBook
    {
        private string id;
        private string nickname; 
        private Admin admin;
        private  List<Cart> carts;
        private List<BookItems> BI{get;set;}
        public string Id{get=>id; set=>id=value;}
        public string Nickname{get=>nickname; set=>nickname=value;}
        public Admin Admin{get=>admin;set=>admin=value;}
        public List<Cart> Carts {get=>this.carts; set=>this.carts=value;}
       
        public customer(Admin admin, string id, string nickname, string fullName, string address, string email):base(fullName, address, email){
            this.Id = id;
            this.Nickname = nickname;
            this.Fullname = fullName;
            this.Address = address;
            this.Email = email;
            this.Admin=admin;
            this.Carts=new List<Cart>();
        }
        public override string InfoUser()
        {
            return $"{Id}\t{Nickname}\t{Fullname}\t{Address}\t{Email}";
        }
        public void ViewBook(){
            admin.ViewBook();
        }
         public List<BookItems> searchBookItems(string bookName){
            return admin.searchBookItems(bookName);
         }
         //Cart
         public void addCart(Cart c){
            this.Carts.Add(c);
            Console.WriteLine("Add Item to cart Successfull!");
         }
         public void ViewCart(){
            foreach (var item in Carts)
            {
                item.ViewCart();
            }
         }
         
         public bool DeleteCart(string idCart){
            var idRemovCart = Carts.FirstOrDefault(a=>a.CartID.Equals(idCart));
            if(idRemovCart == null){
                Console.WriteLine($"ID CartID {idCart} do not exits.");
                return false;
            }else{
                this.Carts.Remove(idRemovCart);
                foreach (var item in Carts)
                {
                    item.removeCartItem(idCart);
                }
                Console.WriteLine("Delete successful!");
                return true;
            }
         }
        public bool UpdateCart(int quanlity, string idBook, string idCart){
            var updateCart = Carts.FindAll(a=>a.CartID==idCart);
            if (updateCart == null)
            {
                Console.WriteLine($"ID Cart {updateCart} do not exits.");
                return false;
            }else{
                foreach (var item in updateCart)
                {
                    item.UpdateCartItem(quanlity,idBook, idCart);
                }
                return true;
            }
        }
    }
}