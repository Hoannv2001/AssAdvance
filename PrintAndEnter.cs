using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssAdvance
{
    public class PrintAndEnter
    {
        public static void MenuRole(){
            Console.WriteLine("*****Menu Role****");
            Console.WriteLine("1: Admin");
            Console.WriteLine("2: Customer");
            Console.WriteLine("3: Exit!!");
        }
        public static void AdminMenu(){
            Console.WriteLine("********** Admin Menu********");
            Console.WriteLine("1: View Your Profile");
            Console.WriteLine("2: Manager Book");
            Console.WriteLine("3: Manager Customer");
            Console.WriteLine("4: Exit!!!");
        }
        public static void PrintManagerBook(){
            Console.WriteLine("********** Manager Customer Menu********");
            Console.WriteLine("1: View information of Book.");
            Console.WriteLine("2: Add Book.");
            Console.WriteLine("3: Update Book.");
            Console.WriteLine("4: Delete Book.");
            Console.WriteLine("5: Search Book.");
            Console.WriteLine("6: Exit");
        }
         public static void PrintManagerCustomer(){
            Console.WriteLine("********** Manager Customer Menu********");
            Console.WriteLine("1: View information of Cusomer.");
            Console.WriteLine("2: Add customer.");
            Console.WriteLine("3: Update Customer.");
            Console.WriteLine("4: Delete Customer.");
            Console.WriteLine("5: Search Customer.");
            Console.WriteLine("6: Exit");
        }
        public static string EnterID(){
            Console.WriteLine("Enter ID of Book ");
            return Console.ReadLine();
        }
         public static string EnterNameBook(){
            Console.WriteLine("Enter Name of Book");
            return Console.ReadLine();
        }
         public static string EnterCategory(){
            Console.WriteLine("Enter Category of Book");
            return Console.ReadLine();
        }
         public static string EnterAuthor(){
            Console.WriteLine("Enter Author of Book");
            return Console.ReadLine();
        }
         public static double EnterPrice(){
            Console.WriteLine("Enter Price of Book");
            return double.Parse(Console.ReadLine());
        }
         public static string EnterDescription(){
            Console.WriteLine("Enter Description of Book");
            return Console.ReadLine();
        }
         public static string EnterIDCs(){
            Console.WriteLine("Enter ID for Customer");
            return Console.ReadLine();
        }
         public static string EnterNickname(){
            Console.WriteLine("Enter nickname of customer");
            return Console.ReadLine();
        }
         public static string EnterFullName(){
            Console.WriteLine("Enter Full Name");
            return Console.ReadLine();
        }
         public static string EnterAdress(){
            Console.WriteLine("Enter Address");
            return Console.ReadLine();
        }
        public static string EnterEmail(){
            Console.WriteLine("Enter email");
            return Console.ReadLine();
        }
        public static string EnterKeySearch(){
            Console.WriteLine("Search");
            return Console.ReadLine();
        }
    }
}