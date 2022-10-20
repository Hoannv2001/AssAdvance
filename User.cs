namespace AssAdvance
{
    public abstract class User
    {
        private string fullName;
        private string address;
        private string email;
        public string Fullname{get=>fullName; set=>fullName=value;}
        public string Address{get=>address;set=>address=value;}
        public string Email{get=>email;set=>email=value;}
        public User(string fullName, string address, string email){
            this.Fullname = fullName;
            this.Address = address;
            this.Email = email;
        }
        public override string ToString()
        {
            return $"{Fullname}\t{Address}\t{Email}";
        }
        public abstract string InfoUser();

    }
}