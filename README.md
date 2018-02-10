# Contacts

#### .Net MVC app that allows user to create, view, and delete contacts, 2-9-18

#### _By Sara Hamilton_

## Description

_This is the Epicodus weekly project for week 1 of the C# course. Its purpose is to display understanding .Net MVC architecture in C#._

#### _Contacts_
* Allows the user to create a new contact by clicking on a navbar link that says "Add Contact"
* Displays an input form that takes in the user's contact info - First name, Last name, Phone number, Street, City, State, and Zipcode - First name is required.  All other input is optional.
* Creates a new contact with the inputted values
* Displays a list of the first and last names of all contacts
* Allows the user to continue to create as many new contacts as they desire and always re-routes to the list of all contact names
* Allows the user to click on a contact name to see all of the properties for that contact
* Allows the user to delete an individual contact by clicking on a button labeled "Clear this Contact" on the page that displays the contact details
* Allows the user to erase all contacts by clicking on a button labeled "Clear All Contacts" on the page that displays all contacts
* Allows the user to navigate between pages with navbar links

### Specifications

#### Minimum Requirements:
* The app contains a Contact class with properties for the person's name, phone number, and address.
* The Homepage of the app at the root path (localhost:5000/contacts) lists all contacts.
* The Homepage contains a link to a page presenting the user with a form they can fill out to create a new Contact. After the form is submitted, the new Contact object is be saved into a static List and the user is be routed back to the homepage.
* The homepage also contains a form with a clear button at the bottom of the list of all contacts. When this is pressed, all Contacts are deleted, and the user is routed back to the homepage.  

#### Additional Specifications:
* Contact names on the homepage are links that redirect the user to a page that displays all of the details about the contact.
* On the contact details page, users can delete the individual contact by clicking a button.  They also have the option to add another contact to the list or return to the homepage without making any changes.  

## Setup/Installation Requirements

* _Clone this GitHub repository_

```
git clone https://github.com/Sara-Hamilton/contacts.git
```

* _Install the .NET Framework_

  .NET Core 1.1 SDK (Software Development Kit)

  .NET runtime.

  See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Run the program_
  1. In the command line, cd into the project folder.
  2. In the command line, type dotnet restore. Enter.  It make take a few minutes to complete this process.
  3. In the command line, type dotnet build. Enter. Any errror messages will be displayed in red.  Errors will need to be corrected before the app can be run. After correcting errors and saving changes, type dotnet build again.  When message says Build succeeded in green, proceed to the next step.
  4. In the command line, type dotnet run. Enter.

* _View program on web browser at port localhost:5000/contacts_

* _Create contacts by clicking the "Add Contact" link, filling out the form, and clicking the "Submit" button_

* _Delete entire list of contacts by clicking the "Clear All Contacts" button._

## Support and contact details

_To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

* HTML
* C#
* .Net Core 1.1

### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
