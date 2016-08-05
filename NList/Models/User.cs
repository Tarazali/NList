using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NList.Models
{
    public class User
    {
        public virtual int user_id { get; set; }
        public virtual string username { get; set; }
        public virtual string email { get; set; }
        public virtual string password { get; set; }
    }
}