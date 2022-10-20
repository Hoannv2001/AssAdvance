namespace AssAdvance
{
    public class Admin:User
    {
        private string idAdmin;
        private List<BookItems> book;
        public string IdAdmin{get=>idAdmin; set=>idAdmin=value;}
        public List<BookItems> Book{get=>book;set=>book=value;}
        public Admin(string id, string fullName, string address, string email):base(fullName, address,email){
            this.IdAdmin = id;
            this.Book= new List<BookItems>();
        }
        public override string InfoUser()
        {
            return $"{IdAdmin}\t{Fullname}\t{Address}\t{Email}";
        }
        public void AddBook(BookItems BI){
            this.Book.Add(BI);
        }
    }
}