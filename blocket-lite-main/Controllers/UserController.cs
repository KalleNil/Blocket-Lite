using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using blocket_lite.Models;
using blocket_lite.Models.ProductViewModel;


namespace blocket_lite.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }

        public RedirectResult UserInsert(UsersModel user)
        {
            
               using (SqliteConnection con =
               new SqliteConnection("Data Source=db.sqlite"))
               {
                    using (var tableCmd = con.CreateCommand())
                    {
                        con.Open();
                        tableCmd.CommandText = $"INSERT INTO users (username, password) VALUES ('{user.username}','{user.password}')";
                        try
                        {
                            tableCmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
               }
            return Redirect("https://localhost:7296/");
        }
    }
}
