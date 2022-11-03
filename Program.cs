using System;
using System.Collections.Generic;
using System.Linq;
namespace AssAdvance
{
    class Program{

        static void Main(string[] args){
            bool flag = false;
            List<customer> customers = new List<customer>();
            List<CartItems>cit = new List<CartItems>();
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
                            Console.WriteLine("1: Register");
                            Console.WriteLine("2: Login");
                            Console.WriteLine("3: Exit");
                            int choiceOfCus = Convert.ToInt32(Console.ReadLine()); 
                            switch (choiceOfCus)
                            {
                                case 1: //register
                                    admin.AddCustomer(new customer(admin, PrintAndEnter.EnterIDCs(),
                                    PrintAndEnter.EnterNickname(), PrintAndEnter.EnterFullName(),
                                    PrintAndEnter.EnterAdress(), PrintAndEnter.EnterEmail()));
                                break;
                                case 2: // login
                                    Console.WriteLine("Enter Email:");
                                    string eC = Console.ReadLine();
                                    Console.WriteLine("Enter ID:");
                                    string id = Console.ReadLine();
                                    customer cs = admin.loginOfCus(eC,id);
                                    if (cs == null)
                                    {
                                        Console.WriteLine("Wrong email or ID");
                                        // flag = true;
                                        break;
                                    }else
                                    {
                                         while (!flag)
                                        {
                                            int choiceCart = Convert.ToInt32(Console.ReadLine());
                                            switch (choiceCart)
                                            {
                                                case 1: //view Profile Customer
                                                     Console.WriteLine(admin.loginOfCus(eC,id).InfoUser());
                                                    //  flag = true;
                                                break;
                                                case 2:// View Book Items
                                                
                                                    cs.ViewBook();
                                                break;
                                                case 3://Add Cart
                                                    // Cart C =new Cart();
                                                    Console.WriteLine("Enter ID Order");
                                                    string idOrder = Console.ReadLine();
                                                    Console.WriteLine("Enter date order");
                                                    string dateOrder = Console.ReadLine();   
                                                    Console.WriteLine("Enter quanlity your are order");
                                                    int n = Convert.ToInt32(Console.ReadLine());
                                                    for (int i = 0; i < n; i++)
                                                    {
                                                        Console.WriteLine("Enter ID Book");                                                         
                                                    string idBook = Console.ReadLine();
                                                    var book = admin.findIDBook(idBook);
                                                    Console.WriteLine("Enter Quanlity Book");
                                                    int quanlity = Convert.ToInt32(Console.ReadLine());                                                        
                                                    CartItems Ci = new CartItems(quanlity,book);
                                                    cs.addCart(new Cart(idOrder, dateOrder,Ci));
                                                    }
                                                    

                                                    // Console.WriteLine(Ci.ToString());
                                                    // Console.WriteLine(book);                                 
                                                break;
                                                case 4://view Cart
                                                // string a = Console.ReadLine();
                                                // cs.ViewCart(a);
                                                // cs.view();
                                                cs.ViewCart();
                                                break;
                                                case 5: // Remove Cart
                                                string idRemove = Console.ReadLine();
                                                cs.DeleteCart(idRemove);
                                                break;
                                                case 6:
                                                    cs.searchBookItems(PrintAndEnter.EnterKeySearch());
                                                break;
                                                case 7://exit
                                                    flag = true;
                                                break;
                                                
                                                
                                                default:
                                                break;
                                            }
                                        }

                                        break;
                                    }
                                case 3: //exit
                                flag = true;
                                break;
                                default:
                                break;
                            }
                        
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