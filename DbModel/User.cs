using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace entityTest2.DbModel
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }

    }
}