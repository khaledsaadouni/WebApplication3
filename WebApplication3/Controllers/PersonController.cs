using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PersonController : Controller
    {
      
        [HttpGet]
        public ViewResult all()
        {
            ViewData["persons"] = personal_info.GetAllPerson();


            return View();
        }
        [HttpPost]
        public RedirectToRouteResult all(person p)
        {
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\khaled\\Desktop\\GL3\\Framework\\tp1\\2022 GL3 .NET Framework TP3 - SQLite database (1).db; Integrated Security= True"))
                {
                    sqlcon.Open();
                    Debug.WriteLine("Connection opened successfully!");
          
                       
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO personal_info  VALUES ('" + p.id + "','" +p.firstname +"','"+p.lastname +"','" + p.email + "','"+ DateTime.Now + "','http://dummyimage.com/115x191.png/dddddd/000000','" + p.country + "'); ", sqlcon);
                    cmd.ExecuteNonQuery();
                } 
            }
            catch (Exception a)
            {
                Debug.WriteLine("Connection refused : " + a.Message);

            }


            return RedirectToAction("all");
        }
 
        public ViewResult Details(int id=0)
        {

        
            return View(personal_info.GetPerson(id));
        }
        [HttpGet]
        public ViewResult Search()
        { 
            return View();
        }
       [HttpPost]
        public RedirectToRouteResult Search(person p)

        {
            int ida=0;
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\khaled\\Desktop\\GL3\\Framework\\tp1\\2022 GL3 .NET Framework TP3 - SQLite database (1).db; Integrated Security= True"))
                {
                    sqlcon.Open();
                    Debug.WriteLine("Connection opened successfully!");


                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM personal_info WHERE first_name='"+p.firstname+"' and country='"+p.country+"' LIMIT 1", sqlcon);
                    using(SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ida = (int)reader["id"];
                        }
                    }
                }
            }
            catch (Exception a)
            {
                Debug.WriteLine("Connection refused : " + a.Message);

            }
            Debug.WriteLine(ida);

        
            return RedirectToAction("Details",new { id = ida});
        } 
 
    }
}
