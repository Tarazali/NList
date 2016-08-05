using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Linq;
using NList.Models;
using NList.Models.NHibernate;

namespace NList.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                var user = session.Query<User>().ToList();
                return View();
            }
        }
    }
}