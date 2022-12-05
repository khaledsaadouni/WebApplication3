using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
         /*  try
            {
                using(SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\khaled\\Desktop\\GL3\\Framework\\tp1\\2022 GL3 .NET Framework TP3 - SQLite database (1).db; Integrated Security= True"))
                {
                    sqlcon.Open();
                    Debug.WriteLine("Connection opened successfully!");
                    SQLiteCommand cmd= new SQLiteCommand(" SELECT * FROM personal_info ",sqlcon);
                    using(SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["id"];
                                string firstname = (string)reader["first_name"];
                                string lastname = (string)reader["last_name"];
                                string email = (string)reader["email"]; 
                                //  DateTime birthday = Convert.ToDateTime(  reader["date_birth"]); 
                                string image = (string)reader["image"];
                                string country = (string)reader["country"];
                                Debug.WriteLine(id + " " + firstname + " " + lastname + " " + email + " " + image + " " + country);
                            }
                        }
                        else
                        {
                            Debug.WriteLine("DataReader returned  0 rows");
                        }
                    }

                }

            }catch(Exception e)
            {
                Debug.WriteLine("Connection Error : " + e.Message);


            }


            Debug.WriteLine("------------------->testing func 1 "  );
            personal_info.GetAllPerson();

            Debug.WriteLine("--------------->testing func 2 "  );
            personal_info.GetPerson(20);*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}