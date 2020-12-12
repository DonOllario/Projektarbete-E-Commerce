using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class Account
    {
        MenuHandler myMenu = new MenuHandler();

        public void LogIn()
        {
            Console.WriteLine("Enter your 'username': ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your 'password': ");
            string password = Console.ReadLine();
            if ((password == "password") && (username == "username"))
            {
                Console.WriteLine("You are welcome.");
            }
            // Behövs FelHantering efter if. (och koppling till sign up?)
        }
          public void SignUp() // Addera felhantering ifall du skulle skriva fel typ av info(?)
            {
                string Edit;
                do
                {
                    Console.WriteLine("Enter your Fullname: ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Enter Adress:");
                    string Adress = Console.ReadLine();
                    Console.WriteLine("Enter your E-mail adress:");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter your Phone number:");
                    string Phonenumber = Console.ReadLine();
                    myMenu.ClearConsoleKOTRM();
                    Console.WriteLine("****************************");
                    Console.WriteLine(" -Welcome  " + user + " this is your Informations.- ");
                    Console.WriteLine(" UserName : " + user);
                    Console.WriteLine(" Adress : " + Adress);
                    Console.WriteLine(" Email : " + Email);
                    Console.WriteLine(" Phonenumber : " + Phonenumber);
                    Console.WriteLine("\nIf you want to Edit your info write 'Edit'. \nOr press any key to continue.");
                    Edit = Console.ReadLine();
                } while (Edit == "Edit");
               
            }

        } 


    }

