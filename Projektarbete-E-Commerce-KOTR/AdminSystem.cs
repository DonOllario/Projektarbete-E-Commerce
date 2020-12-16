using System;

namespace Projektarbete_E_Commerce_KOTR
{
    class AdminSystem
    {
        public MenuHandler myMenu = new MenuHandler();
        public Product productReference = new Product();

        public void HandleAdmin(string HandleAdminInput)
        {
            
            if (HandleAdminInput == "1")
            {
                //Add Existing product
                myMenu.ClearConsoleKOTRM();
                productReference.AddProductAsAdmin();
                myMenu.GoBack();
            }
            else if (HandleAdminInput == "2")
            {
                //Remove existing product
                myMenu.ClearConsoleKOTRM();
                productReference.RemoveProductAsAdmin(Product.ProductList);
                myMenu.GoBack();
            }
            else if (HandleAdminInput == "3") 
            {

                // Change existing product
                myMenu.ClearConsoleKOTRM();
                productReference.ChangeProductAsAdmin(Product.ProductList);
                Console.ReadKey();
                myMenu.GoBack();

            }
            else if (HandleAdminInput == "4") 
            {
                //Go back
                myMenu.GoBack();
            }
            else
            {
                Console.WriteLine("Incorrect Input, Please try again");
            }
        }
    }
}