using System;
using System.Collections.Generic;

class LibraryCollection{
private List<Patron> PatronList = new List<Patron>();
private List<Book> BooksList = new List<Book>();
 public List<Book> RentalCart = new List<Book>();

public void AddPatron(Patron p)
{
  PatronList.Add(p);
  Patron p1 = p;
  Console.WriteLine(p1.FirstName +" "+ p1.LastName + " Sucessfully added to Patron List.");
}

public void RemovePatron(Patron p)
{
  PatronList.Remove(p);
  Patron p1 = p;
  Console.WriteLine(p1.FirstName + " " + p1.LastName + " Sucessfully Removed from Patron List.");
}

public void DisplayPatronInfo()
{
  foreach (var Patron in PatronList)
  {
    Patron.Display();
  }
}

public void AddToCollection(Book b)
{
  BooksList.Add(b);
  Console.WriteLine("Added Book to Collection");
}

public void RemoveFromCollection(Book b)
{
  BooksList.Remove(b);
  Console.WriteLine("Removed Book from Collection.");
}

public void DisplayCollection()
{
  foreach (var Book in BooksList)
  {
    Book.Display();
  }
}

public void ProcessRental(Patron p)
{
  foreach (var Book in RentalCart)
  {
    BooksList.Remove(Book);
    Book b1 = Book;
    Console.WriteLine("Processed Rental Of: " + b1.Title);
  }
}
/*
public void ProcessReturns(Book b, Patron p)
{
  Book b1 = b;
  Patron p1 = p;
  BooksList.Find(Book => Book == Book);
    if (Rental.DateRented < Rental.DateDue)
    {
      FineAmountDue += 10;
    }
  Console.WriteLine("Processed Rental Of: " + b1.Title);
}
/*
	Find the book in the rentalcart of the patron.
	Check the due date of the book. 
  •	If it is earlier than today’s date, add $10 to the FineAmountDue. 
  •	Show a message that there is a fine of $10.
	Remove the book from the rental cart of the patron.
	Add the book back to the LibraryCollection’s booklist.
*/


}