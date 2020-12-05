using System;
using System.Collections.Generic;


class Patron : Person
{
 public string LibraryId { get; set; }
 public DateTime StartDate { get; set; }
 public DateTime EndDate { get; set; }
 public bool IsAccountActive { get; set; }
 public List<Book> RentalCart = new List<Book>();
 public double FineAmountDue { get; set; }

  public Patron(string FirstName, string LastName, string LibraryId)
  {
  this.FirstName = FirstName;
  this.LastName = LastName;
  this.LibraryId = LibraryId;
  this.FineAmountDue = 0;
  this.StartDate = DateTime.Today;
  this.IsAccountActive = true;
  }

  public void Display()
  {
  Console.WriteLine("Patron ID = " + LibraryId + ", Patron's Name Is: " + FirstName + " " + LastName + ".");
  }

  public void AddToRentalCart(Book b, DateTime DateDue)
  {
  RentalCart.Add(b);
  //I feel as though there is a better way to pass these values of the Book object than creating a duplicate just for the method to use. /shrug
  Book b1 = b;
  Console.WriteLine("Added " + b1.Title + " To Rental Cart For Patron " + FirstName + " " + LastName);
  }
  
  public void RemoveFromRentalCart(Book b)
  {
    RentalCart.Remove(b);
    Book b1 = b;
    Console.WriteLine("Removed " + b1.Title + " From " + FirstName + " " + LastName + "'s Rental Cart");
  }

}