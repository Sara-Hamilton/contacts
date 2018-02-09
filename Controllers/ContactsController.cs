using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Contacts.Models;

namespace Contacts.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }

    [HttpPost("/contacts")]
    public ActionResult Create()
    {
      Contact newContact = new Contact (Request.Form["first-name"], Request.Form["last-name"], Request.Form["phone"], Request.Form["street"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
      newContact.Save();
      List<Contact> allContacts = Contact.GetAll();
      return View("Index", allContacts);
    }

    [HttpGet("/contacts/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/contacts/delete")]
    public ActionResult DeleteAll()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
