namespace AssAdvance
{
    public class Admin:User,ISearchBook
    {
        private string idAdmin;
        private List<BookItems> bookList;
        private List<customer> cs;
        
        public string IdAdmin{get=>idAdmin; set=>idAdmin=value;}
        public List<BookItems> BookList{get=>bookList;set=>bookList=value;}
        public List<customer> Cs{get=> cs; set=>cs=value;}
        public Admin(string id, string fullName, string address, string email):base(fullName, address,email){
            this.IdAdmin = id;
            this.BookList= new List<BookItems>();
            this.Cs=new List<customer>();
        }
        public override string InfoUser()
        {
            return $"{IdAdmin}\t{Fullname}\t{Address}\t{Email}";
        }
        public void AddBook(BookItems BI){
            this.BookList.Add(BI);
        }
        public bool UpdateBook(string idUpdate,string uNameBook, string uCategroty, string uAuthor, double uPrice, string uDescription){
            var updatBook = BookList.FirstOrDefault(a=>a.Id.Equals(idUpdate));
            if(updatBook==null){
                  Console.WriteLine($"ID book {updatBook} do not exits.");
                return false;
            }else{
                updatBook.BookName=uNameBook;
                updatBook.Category=uCategroty;
                updatBook.Author=uAuthor;
                updatBook.Price=uPrice;
                updatBook.Description=uDescription;
                return true;
            
            }
        }
        public bool Remove(string removeIdBook){
            var removeBook = BookList.FirstOrDefault(a=>a.Id.Equals(removeIdBook));
            if(removeBook == null){
                Console.WriteLine($"ID book {removeIdBook} do not exits.");
                return false;
            }else{
                this.BookList.Remove(removeBook);
                return true;
            }
        }
        public void ViewBook(){
            foreach (var item in BookList)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void AddCustomer(customer c){
            this.Cs.Add(c);
        }
        public bool UpdateCustomer(Admin admin, string idC,string nickname, string fullName, string address){
            var idCUpdate = Cs.FirstOrDefault(a=>a.Id.Equals(idC));
            if(idCUpdate==null){
                Console.WriteLine($"ID customer {idCUpdate} do not exits.");
                return false;
            }else
            {
                idCUpdate.Nickname = nickname;
                idCUpdate.Fullname = fullName;
                idCUpdate.Address = address;
                return true;
            }
        }
        public bool RemoveCustomer(string idC){
            var idCUpdate = Cs.FirstOrDefault(a=>a.Id.Equals(idC));
            if(idCUpdate == null){
                Console.WriteLine($"ID customer {idCUpdate} do not exits.");
                return false;
            }else{
                this.Cs.Remove(idCUpdate);
                return true;
            }
        }
        public void ViewCustomer(){
            foreach (var item in Cs)
            {
                Console.WriteLine(item.InfoUser());
            }
        }
        public List<BookItems> searchBookItems(string bookName){
            var searchBook = BookList.FindAll(a=>a.BookName == bookName);
            foreach (var item in searchBook)
            {
                Console.WriteLine(item);
            }
            return searchBook;
        }
        public List<customer> searchCus(string csId){
            var searchCus = Cs.FindAll(a=>a.Id == csId);
            foreach (var item in searchCus)
            {
                Console.WriteLine(item.InfoUser());
            }
            return searchCus;
        }

    }
}