namespace AssAdvance
{
    public class BookItems:IId
    {
        private string bookName;
        private string category;
        private string author;
        private double price;
        private string desciption;
        public string Id{get;set;}
        public string BookName{get=>bookName; set=>bookName=value;}
        public string Category{get=>category;set=>category=value;}
        public string Author{get=>author; set=>author=value;}
        public double Price{get=>price; set=>price=value;}
        public string Description{get=>desciption;set=>desciption=value;}
        public BookItems(string id, string bookname, string category, string author, double price, string descriotion){
            this.Id =id;
            this.BookName=bookName;
            this.Category=category;
            this.Author=author;
            this.Price = price;
            this.Description=desciption;
        }
        public override string ToString()
        {
            return $"{Id}\t{BookName}\t{Category}\t{Author}\t{Price}\t{Description}";
        }
    }
}