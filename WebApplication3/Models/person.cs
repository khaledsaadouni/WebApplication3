using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{

    public class person
    {
    public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }
        public string image { get; set; }
        public string country { get; set; }
        public person(int id, string firstname, string lastname, string email, DateTime birthday, string image, string country)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.birthday = birthday;
            this.image = image;
            this.country = country;
        }
        public person()
        {

        }
    }
}