using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class personal_info
    {
       public static List<person> GetAllPerson()
        {
             List<person>  l = new List<person>();
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\khaled\\Desktop\\GL3\\Framework\\tp1\\2022 GL3 .NET Framework TP3 - SQLite database (1).db; Integrated Security= True"))
                {
                    sqlcon.Open();
                    Debug.WriteLine("Connection opened successfully!");
                    SQLiteCommand cmd = new SQLiteCommand(" SELECT * FROM personal_info ", sqlcon);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["id"];
                                string firstname = (string)reader["first_name"];
                                string lastname = (string)reader["last_name"];
                                string email = (string)reader["email"];
                                DateTime birthday= DateTime.Now;
                        
                                string image = (string)reader["image"];
                                string country = (string)reader["country"];
                                l.Add(new person(id, firstname, lastname, email, birthday, image, country));
                            //     Debug.WriteLine(id + " " + firstname + " " + lastname + " " + email + " "+birthday+" " + image + " " + country);
                               // Debug.WriteLine(DateTime.ParseExact((string)reader["date_birth"], "dd/MM/yyyy", null)); 
                               
                            }
                        }
                        else
                        {
                            Debug.WriteLine("DataReader returned  0 rows");
                        }
                    }

                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Connection Error : " + e.Message);


            }
            return l ;
        }
       public static person GetPerson(int id) {
            person p = new person();
            try
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=C:\\Users\\khaled\\Desktop\\GL3\\Framework\\tp1\\2022 GL3 .NET Framework TP3 - SQLite database (1).db; Integrated Security= True"))
                {
                    sqlcon.Open();
                    Debug.WriteLine("Connection opened successfully!");
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM personal_info WHERE id="+id+" LIMIT 1;" , sqlcon);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             
                                int ida = (int)reader["id"];
                                string firstname = (string)reader["first_name"];
                                string lastname = (string)reader["last_name"];
                                string email = (string)reader["email"];

                                DateTime birthday = DateTime.Now;
                                string image = (string)reader["image"];
                                string country = (string)reader["country"];
                                p=new person(ida, firstname, lastname, email, birthday, image, country);
                            //  Debug.WriteLine(ida + " " + firstname + " " + lastname + " " + email + " " + image + " " + country);
     


                        }
                    
                    }

                }

            }
            catch (Exception e)
            {
                Debug.WriteLine("Connection Error : " + e.Message);


            }
            return  p;
        }
    }
}