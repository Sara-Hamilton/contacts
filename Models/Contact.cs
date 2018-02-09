using System.Collections.Generic;
using System;

namespace Contacts.Models
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _phone;
    private Address _address;
    // private string _street;
    // private string _city;
    // private string _state;
    // private string _zip;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string firstName, string lastName, string phone, Address address)
    {
      _firstName = firstName;
      _lastName = lastName;
      _phone = phone;
      // _street = street;
      // _city = city;
      // _state = state;
      // _zip = zip;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetFirstName()
    {
      return _firstName;
    }

    public void SetFirstName(string firstName)
    {
      _firstName = firstName;
    }

    public string GetLastName()
    {
      return _lastName;
    }

    public void SetLastName(string lastName)
    {
      _lastName = lastName;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone(string phone)
    {
      _phone = phone;
    }

    public Address GetAddress()
    {
      return _address;
    }

    public void SetAddress(Address address)
    {
      _address = address;
    }

    // public string GetStreet()
    // {
    //   return _street;
    // }
    //
    // public void SetStreet(string street)
    // {
    //   _street = street;
    // }
    //
    // public string GetCity()
    // {
    //   return _city;
    // }
    //
    // public void SetCity(string city)
    // {
    //   _city = city;
    // }
    //
    // public string GetState()
    // {
    //   return _state;
    // }
    //
    // public void SetState(string state)
    // {
    //   _state = state;
    // }
    //
    // public string GetZip()
    // {
    //   return _zip;
    // }
    //
    // public void SetZip(string zip)
    // {
    //   _zip = zip;
    // }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

    // if contact is removed from the list, the contact ids no longer match up with their index number in the list, contact properties are altered with DeleteOne method instead
    public void DeleteOne()
    {
      _firstName = "deleted";
      _lastName = "";
      _phone = "";
      _address = null;
      // _street = "";
      // _city = "";
      // _state = "";
      // _zip = "";
    }
  }
}
