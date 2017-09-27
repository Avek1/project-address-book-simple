using AddressBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Controllers
{
    [RoutePrefix("contact")]
    public class ContactController : Controller
    {
        // GET: Contact
        [Route("{id:int}")]
        public ActionResult Index(int id = 0)
        {
            ItemViewModel<int> model = new ItemViewModel<int>();
            model.Item = id;

            return View(model);
        }


        // original
        // GET: Contact
        //public ActionResult Index()
        //{
        //    return View();
        //}

        ////////// angular

        // GET: Contact
        public ActionResult IndexNg()
        {
            return View();
        }

        public ActionResult IndexNg2()
        {
            return View();
        }
    }
}