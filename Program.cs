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
                                                                    Console.WriteLine("add successfull---------");
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
                                                                Console.WriteLine("Update successfull---------");
                                                            }
                                                            catch (FormatException ex)
                                                                {
                                                                    Console.WriteLine("Enter wrong data type"+ex.Message);
                                                                }
                                                            break;
                                                        case 4: // remove cus
                                                            Console.WriteLine("Remove Customer******");
                                                            admin.RemoveCustomer(PrintAndEnter.EnterIDCs());
                                                            Console.WriteLine("Remove successfull---------");
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
                            PrintAndEnter.LoginAndRegisterCs();
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
                                        break;
                                    }else
                                    {
                                         while (!flag)
                                        {
                                            PrintAndEnter.PrintAdcart();
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
                                                    Console.WriteLine("Enter ID Order");
                                                    string idOrder = Console.ReadLine();
                                                    Console.WriteLine("Enter date order");
                                                    string dateOrder = Console.ReadLine();   
                                                    Console.WriteLine("Enter quanlity your are order");
                                                    int n = Convert.ToInt32(Console.ReadLine());
                                                    for (int i = 0; i < n; i++)
                                                    {   
                                                        Console.WriteLine("Enter ID Book: ");  
                                                        string idBook = Console.ReadLine(); 
                                                        Console.WriteLine("Enter Quanlity: ");   
                                                        int quanlity = Convert.ToInt32(Console.ReadLine()); 
                                                        CartItems CI = new CartItems(quanlity, idOrder);                                                       
                                                        var newBookItems = admin.findIDBook(idBook); 
                                                        if (newBookItems==null)
                                                        {
                                                            Console.WriteLine("Ko cos sach nay");
                                                        }else
                                                        {
                                                            CI.addBookInCartItem(newBookItems);
                                                            cit.Add(CI);
                                                        }
                                                
                                                    }
                                                    cs.addCart(new Cart(idOrder, dateOrder, cit));
                                                break;
                                                case 4://Update Cart
                                                    Console.WriteLine("Enter ID cart Update:");
                                                    string idCart = Console.ReadLine();
                                                    Console.WriteLine("Enter IDBook Update in Cart:");
                                                    string idBookU = Console.ReadLine();
                                                    Console.WriteLine("Enter quantity Update:");
                                                    int quanlityU = Convert.ToInt32(Console.ReadLine());
                                                    cs.UpdateCart(quanlityU, idBookU,idCart);
                                                break;
                                                case 5: // Remove Cart
                                                Console.WriteLine("Enter Cart ID delete:");
                                                string idRemove = Console.ReadLine();
                                                cs.DeleteCart(idRemove);
                                                break;
                                                case 6: // View Cart
                                                    cs.ViewCart();
                                                break;
                                                case 7://search book
                                                Console.WriteLine("Enter book name Search: ");
                                                string nameBook =Console.ReadLine();
                                                cs.searchBookItems(nameBook);
                                                break;                                                
                                                case 8://exit
                                                    flag = true;
                                                break;                                                                                          
                                                default:
                                                    Console.WriteLine("Please Enter choice have in Menu");
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
                        return;
           
                    default:
                        Console.WriteLine("Please Enter choice have in Menu");
                        break;
                }
                
            }
        }

    }
}