using System;

namespace Projektarbete_E_Commerce_KOTR
{
    static class Account
    {
        static MenuHandler myMenu = new MenuHandler();

        public static string Name { get; set; }
        public static string UserName { get; set; }
        public static string Adress { get; set; }
        private static string Password { get; set; }
        public static bool LoginStatus { get; set; }

        public static void SignUp()
        {
            string edit = "edit";
            while (edit == "edit") 
            {
                Console.WriteLine("Enter your name: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter your username: ");
                UserName = Console.ReadLine();
                Console.WriteLine("Enter a password: ");
                Password = Console.ReadLine();
                Console.WriteLine("Enter your adress: ");
                Adress = Console.ReadLine();
                myMenu.ClearConsoleKOTRM();
                Console.WriteLine("**********************************************");
                Console.WriteLine("Welcome, " + Name + ". This is your account information: \n");
                Console.WriteLine("Username: " + UserName);
                Console.WriteLine("Adress: " + Adress);
                Console.WriteLine("\nIf you want to edit your info write 'edit'.");
                Console.WriteLine("Or press any key to continue.");
                edit = Console.ReadLine().ToLower();
            }
        }
        public static void LogIn()
        {
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            if ((password == Password) && (username == UserName))
            {
                Console.WriteLine("\nLogin successful!");
                LoginStatus = true;
            }
            else
            {
                Console.WriteLine("\nThe entered login information was wrong.");
            }
        }
    } 
}

