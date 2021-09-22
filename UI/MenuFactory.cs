using DL;
using RBBL;

namespace UI
{
    public class MenuFactory
    {
        public static IMenu GetMenu(string menuString)
        {
            switch (menuString.ToLower())
            {
                case "main":
                    return new MainMenu();
                //case "customer":
                    //return new CustomerMenu();
                case "admin":
                    return new MainMenu();
                default:
                    return null;
            }
        }
    }
}