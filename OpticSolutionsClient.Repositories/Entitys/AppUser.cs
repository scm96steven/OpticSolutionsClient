using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace OpticSolutions.Repositories.Entitys
{
    public class AppUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public byte[] UserPhoto { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }

    }
}