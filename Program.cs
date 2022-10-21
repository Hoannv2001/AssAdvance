namespace AssAdvance
{
    class Program{
        static void Main(string[] args){
            Admin admin = new Admin("1","Nguyen Van Hoan","Da Nang","hoannvgcs190736@fpl.edu");
            while (true)
            {
                PrintAndEnter.MenuRole();
                Console.WriteLine("Please Enter Your option:");
                int choiceRole = Convert.ToInt32(Console.ReadLine());
                switch (choiceRole)
                {
                    case 1:
                        AdminFunction();
                        break;
                    case 2:
                        Console.WriteLine("fff");
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Please Enter choice have in Menu");
                        break;
                }
                
            }
        }
        static void AdminFunction(){
            Admin admin = new Admin("1","Nguyen Van Hoan","Da Nang","hoannvgcs190736@fpl.edu");
            PrintAndEnter.AdminMenu();
            while (true)
            {
                PrintAndEnter.AdminMenu();
                Console.WriteLine("Please Enter Your option:");
                int choiceAdmin = Convert.ToInt32(Console.ReadLine());
                switch(choiceAdmin){
                    case 1:
                        Console.WriteLine(admin.InfoUser());
                        break;
                    case 2:
                        Console.WriteLine("Enter Book Quantity You want to Add:");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            try
                            {
                                admin.AddBook(new BookItems(PrintAndEnter.EnterID(), PrintAndEnter.EnterNameBook(),
                                        PrintAndEnter.EnterCategory(),PrintAndEnter.EnterAuthor(),
                                        PrintAndEnter.EnterPrice(), PrintAndEnter.EnterDescription()));
                            }
                            catch (FormatException ex)
                            {
                                
                                Console.WriteLine("Enter wrong data type"+ex.Message);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Update Book******");
                        try
                        {
                             admin.UpdateBook(PrintAndEnter.EnterID(),PrintAndEnter.EnterNameBook(),
                                PrintAndEnter.EnterCategory(),PrintAndEnter.EnterAuthor(),
                                PrintAndEnter.EnterPrice(), PrintAndEnter.EnterDescription());
                        }
                        catch (FormatException ex)
                            {
                                Console.WriteLine("Enter wrong data type"+ex.Message);
                            }
                        break;
                    case 4:
                        Console.WriteLine("Remove Book******");
                        admin.Remove(PrintAndEnter.EnterID());                   
                        break;
                    case 5:
                        admin.ViewBook();
                        break; 
                    case 6:
                        ManagerCustomer();
                        break; 
                    case 7:
                        break;
                    case 8:
                        admin.searchBookItems(PrintAndEnter.EnterKeySearch());
                    
                        break;
                    default:
                    Console.WriteLine("Please Enter choice have in Menu");
                    break;
                }
            }
        }
        static void ManagerCustomer(){
            Admin admin = new Admin("1","Nguyen Van Hoan","Da Nang","hoannvgcs190736@fpl.edu");
            while (true)
            {
                PrintAndEnter.PrintManagerCustomer();
                Console.WriteLine("Please Enter Your option:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        admin.ViewCustomer();
                        // Console.WriteLine(admin.InfoUser());
                        break;
                    case 2:
                        Console.WriteLine("Enter Customer Quantity You want to Add:");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            try
                            {
                                admin.AddCustomer(new customer(admin, PrintAndEnter.EnterIDCs(),
                                PrintAndEnter.EnterNickname(), PrintAndEnter.EnterFullName(),
                                PrintAndEnter.EnterAdress(), PrintAndEnter.EnterEmail()));
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine("Enter wrong data type"+ex.Message);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Update Customer******");
                        try
                        {
                            admin.UpdateCustomer(admin, PrintAndEnter.EnterIDCs(),
                            PrintAndEnter.EnterNickname(),PrintAndEnter.EnterFullName(),
                            PrintAndEnter.EnterAdress());
                        }
                        catch (FormatException ex)
                            {
                                Console.WriteLine("Enter wrong data type"+ex.Message);
                            }
                        break;
                    case 4:
                        Console.WriteLine("Remove Customer******");
                        admin.RemoveCustomer(PrintAndEnter.EnterIDCs());
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please Enter choice have in Menu");
                        break;
                }
            }
        }

    }
}
