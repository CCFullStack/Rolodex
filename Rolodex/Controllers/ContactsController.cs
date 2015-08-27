using Rolodex.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rolodex.Controllers
{
    public class ContactsController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Contacts
        public ActionResult Index()
        {
            var contacts = (from c in _db.Contacts.Include(c => c.Address)
                           select c).ToList();

            return View(contacts);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(Contact collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            var contact = _db.Contacts.Find(id);
            return View(contact);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contact contact)
        {
            if (ModelState.IsValid) {
                var dbContact = _db.Contacts.Find(id);
                dbContact.Name = contact.Name;
                dbContact.Phone = contact.Phone;
                dbContact.Birthday = contact.Birthday;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            // else there was an error
            return View();
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contacts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
