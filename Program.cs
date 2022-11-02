namespace AssAdvance
{
    class Program{
        static void Main(string[] args){
            bool flag = false;
            List<customer> customers = new List<customer>();
            // User u = new User();
            
            // b.ToString();
            Admin admin = new Admin("1","Nguyen Van Hoan","Da Nang","hoannvgcs190736@fpl.edu");
            while (!flag)
            {
                PrintAndEnter.MenuRole();
                Console.WriteLine("Please Enter Your option:");
                int choiceRole = Convert.ToInt32(Console.ReadLine());
                switch (choiceRole)
                {
                    case 1:// admin
                    do
                        {
                            Console.WriteLine("Enter Email");
                            string e = Console.ReadLine();
                            if (e=="hoannvgcs190736@fpl.edu")
                            {
                                while (!flag)
                                    {
                                        PrintAndEnter.AdminMenu();
                                        Console.WriteLine("Please Enter your choice:");
                                        int choiceAdmin = Convert.ToInt32(Console.ReadLine());
                                        switch (choiceAdmin)
                                        {
                                            case 1://profile admin
                                                Console.WriteLine(admin.InfoUser());
                                                break;
                                            case 2:// Manager Book  
                                                while (!flag)
                                                    {
                                                        PrintAndEnter.PrintManagerBook();
                                                        Console.WriteLine("Please Enter Your option:");
                                                        int choice = Convert.ToInt32(Console.ReadLine());
                                                        switch (choice)
                                                        {
                                                            case 1: // vew Book Items
                                                                admin.ViewBook();
                                                                break;
                                                            case 2: // add new Book
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
                                                            case 3: // update book
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
                                                            case 4: // Remove Book
                                                                Console.WriteLine("Remove Book******");
                                                                admin.Remove(PrintAndEnter.EnterID());                   
                                                                break;
                                                            case 5: // search book
                                                                admin.searchBookItems(PrintAndEnter.EnterKeySearch());
                                                                break;
                                                            case 6: // exit
                                                                flag = true;
                                                                break;
                                                            default:
                                                                Console.WriteLine("Please Enter choice have in Menu");
                                                                break;
                                                        }
                                                    }
                                                flag = false;
                                                break;
                                            case 3:// manager customer
                                                while (!flag)
                                                {
                                                    PrintAndEnter.PrintManagerCustomer();
                                                    Console.WriteLine("Please Enter Your option:");
                                                    int choice = Convert.ToInt32(Console.ReadLine());
                                                    switch (choice){
                                                        case 1: // view Cus
                                                            admin.ViewCustomer();
                                                            break;
                                                        case 2: // add cus
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
                                                        case 3: // update cus
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
                                                        case 4: // remove cus
                                                            Console.WriteLine("Remove Customer******");
                                                            admin.RemoveCustomer(PrintAndEnter.EnterIDCs());
                                                            break;
                                                        case 5: // search cus
                                                            admin.searchCus(PrintAndEnter.EnterKeySearch());
                                                            break;
                                                        case 6: //exit
                                                            flag = true;
                                                            break;
                                                        default:
                                                            Console.WriteLine("Please Enter choice have in Menu");
                                                            break;
                                                    }
                                                }
                                                flag = false;
                                            break;
                                            case 4:// exit
                                                flag = true;
                                                break;
                                            default:
                                                Console.WriteLine("Please Enter choice have in Menu");
                                                break;
                                        }
                                    }
                            }else{
                                Console.WriteLine("You are not admin");
                                break;
                            }
                        } while (!flag);
                        flag = false;
                        break;
                    case 2://customer
                        do
                        {
                            // List<customer> cs = new List<customer>();
                            // Console.WriteLine("Enter Email");
                            // string eC = Console.ReadLine();
                            // Console.WriteLine("Enter ID");
                            // string id = Console.ReadLine();
                            // bool a = cs.c
                            // if (Comparer())
                            // {
                                
                            // }
                        } while (!flag);
                         flag = false;
                        break;
                    case 3: //exit
                        Console.WriteLine("fff");
                        admin.ViewBook();
                        Console.WriteLine("fff");
                        admin.ViewCustomer();
                        break;
                    case 4: //test
                    admin.ViewBook();
                    break;
                    default:
                        Console.WriteLine("Please Enter choice have in Menu");
                        break;
                }
                
            }
        }

    }
}