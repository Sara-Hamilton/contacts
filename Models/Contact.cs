using System.Collections.Generic;
using System;

namespace Contacts.Models
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private int _phone;
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string firstName, string lastName, int phone, string street, string city, string state, int zip)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phone = phone;
      _street = street;
      _city = city;
      _state = state;
      _zip = zip;
    }

    public string GetFirstName()
    {
      return _firstName;
    }

    public string SetFirstName(string firstName)
    {
      _firstName = firstName;
    }

    public string GetLastName()
    {
      return _lastName;
    }

    public string SetLastName(string lastName)
    {
      _lastName = lastName;
    }

    public int GetPhone()
    {
      return _phone;
    }

    public int SetPhone(int phone)
    {
      _phone = phone;
    }

    public string GetStreet()
    {
      return _street;
    }

    public string SetStreet(string street)
    {
      _street = street;
    }

    public string GetCity()
    {
      return _city;
    }

    public string SetCity(string city)
    {
      _city = city;
    }

    public string GetState()
    {
      return _state;
    }

    public string SetState(string state)
    {
      _state = state;
    }

    public int GetZip()
    {
      return _zip;
    }

    public int SetZip(int zip)
    {
      _zip = zip;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public void Save();
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
