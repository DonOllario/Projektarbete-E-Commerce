using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_E_Commerce_KOTR
{
    class User
    {
        public void SignIn()
        {
            Console.WriteLine("Enter your 'username' : ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your 'password' : ");
            string password = Console.ReadLine();
            if ((password == "password") && (username == "username"))
            {
                Console.WriteLine("you are welcome");
            }
        }
          public void signup()
            {
                string Edit;
                do
                {
                    Console.WriteLine("Enter your Fullname : ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Enter Adress :");
                    string Adress = Console.ReadLine();
                    Console.WriteLine("Enter your E-mail adress :");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter Phonenumber : ");
                    string Phonenumber = Console.ReadLine();
                    Console.WriteLine("****************************");
                    Console.WriteLine(" Welcome  " + user + " this is your Informations ");
                    Console.WriteLine(" UserName : " + user);
                    Console.WriteLine(" Adress : " + Adress);
                    Console.WriteLine(" Email : " + Email);
                    Console.WriteLine(" Phonenumber : " + Phonenumber);
                    Console.WriteLine("If you want Edit your Info Write 'Edit' : ");
                    Edit = Console.ReadLine();
                } while (Edit == "Edit");
               
            }

        } 


    }

