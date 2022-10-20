namespace AssAdvance
{
    class Program{
        static void Main(string[] args){
            // Console.WriteLine("dddd");
            // User u = new User("hhhh", "Nghe an", "@gmail.com");
            // Console.WriteLine(u.ToString());
            customer c = new customer("1","hoannv","Nguyen van hoan","nghe an","@gmail.com");
            Admin a = new Admin("2", "Nguyen van hoan","nghe an","@gmail.com");
            Console.WriteLine(c.InfoUser());
            Console.WriteLine(a.InfoUser());
        }
    }
}
