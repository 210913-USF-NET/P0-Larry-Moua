using DL;
using RBBL;
using DL.Entities;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace UI
{
    public class MenuFactory
    {
        public static IMenu GetMenu(string menuString)
        {
            string connectionString = File.ReadAllText(@"../connectionString.txt");

            DbContextOptions<kpopsnapshotdbContext> options = new DbContextOptionsBuilder<kpopsnapshotdbContext>().UseSqlServer(connectionString).Options;
            
            kpopsnapshotdbContext context = new kpopsnapshotdbContext(options);

            switch (menuString.ToLower())
            {
                case "main":
                    return new MainMenu();
                case "customer":
                    return new MainMenu();
                case "admin":
                    return new MainMenu();
                default:
                    return null;
            }
        }
    }
}