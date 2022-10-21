namespace AssAdvance
{
    public class customer:User
    {
        private string id;
        private string nickname; 
        private Admin admin;
        public string Id{get=>id; set=>id=value;}
        public string Nickname{get=>nickname; set=>nickname=value;}
        public Admin Admin{get=>admin;set=>admin=value;}
        public customer(Admin admin, string id, string nickname, string fullName, string address, string email):base(fullName, address, email){
            this.Id = id;
            this.Nickname = nickname;
            this.Admin=admin;
        }
        public override string InfoUser()
        {
            return $"{Id}\t{Nickname}\t{Fullname}\t{Address}\t{Email}";
        }
        // public List<BookItems> searchBookItems(string id){
        //     // List<BookItems> bl = new List<BookItems>();
        //     return admin.searchBookItems("1");
        //     // return searchBook;
        // }
    }
}