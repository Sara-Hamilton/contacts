using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
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
      Address newAddress = new Address (Request.Form["street"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
      Contact newContact = new Contact (Request.Form["first-name"], Request.Form["last-name"], Request.Form["phone"], newAddress);
      Dictionary<string, object> ContactInfo = new Dictionary<string, object>();
      ContactInfo.Add("address", newAddress);
      ContactInfo.Add("contact", newContact);
      List<Contact> allContacts = Contact.GetAll();

      // return View("Index", allContacts);
      return View("Index", ContactInfo);
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

    [HttpPost("/contacts/delete/one")]
    public ActionResult DeleteOne()
    {
      Contact foundContact =  Contact.Find(Int32.Parse(Request.Form["contact-id"]));
      List<Contact> allContacts = Contact.GetAll();
      // if contact is removed from the list, the contact ids no longer match up with their index number in the list, contact properties are altered with DeleteOne method instead
      // allContacts.Remove(foundContact);
      foundContact.DeleteOne();
      return View("Index", allContacts);
    }

    [HttpGet("/contacts/{id}")]
    public ActionResult Details(int id)
    {
      Contact contact = Contact.Find(id);
      return View(contact);
    }

  }
}
