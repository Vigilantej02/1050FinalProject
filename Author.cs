using System;
using System.Collections.Generic;

class Author : Person
{ //this is a list of the authors books, ingeniusly titled "BooksList"
  private List<Book> BooksList = new List<Book>();

  //assigning parameters as values for the DisplayInfo() method
  public Author(string FirstName, string LastName, string Email) 
        {
          this.FirstName = FirstName;
          this.LastName = LastName;
          this.Email = Email;
        }
  //this method displays the Author objects information
  public void DisplayInfo()
  {
    Console.WriteLine("The authors name is " + FirstName + " " + LastName + ". You can email them at " + Email);
  }

  //this method displays all the books belonging to the author
  public void DisplayBooks()
    //test to see if the DisplayBooks() method is running
  { Console.WriteLine("Displaying Books");
    //logic to Display each Book in the list
    foreach (var Book in BooksList)
    {
      Book.Display();
    }
  }

  //This method adds a book to the authors list of books.
  public void AddBook(Book b)
  {
    BooksList.Add(b);
    this.FirstName = FirstName;
    this.LastName = LastName;
  }

  //This method uses the find method to find a matching ISBN, and remove it from the list
  public void RemoveBook(string ISBN)
  {
    BooksList.Remove(BooksList.Find(Book => Book.ISBN == ISBN));
  }
}