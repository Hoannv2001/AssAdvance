namespace AssAdvance
{
    public class BookItems:IId
    {
        private string id;
        private string bookName;
        private string category;
        private string author;
        private double price;
        private string desciption;
        public string Id{get=>id;set=>id=value;}
        public string BookName{get=>bookName; set=>bookName=value;}
        public string Category{get=>category;set=>category=value;}
        public string Author{get=>author; set=>author=value;}
        public double Price{get=>price; set=>price=value;}
        public string Description{get=>desciption;set=>desciption=value;}
        public BookItems(){
            
        }
        public BookItems(string id, string bookname, string category, string author, double price, string description){
            this.Id =id;
            this.BookName=bookname;
            this.Category=category;
            this.Author=author;
            this.Price = price;
            this.Description=description;
        }
        public override string ToString()
        {
            return $"{Id}\t {BookName}\t {Category}\t {Author}\t {Price}\t {Description}";
        }
    }
}