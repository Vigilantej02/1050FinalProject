using System;

class Rental
{
 public Book b { get; set; }
 public virtual DateTime DateRented{ get; set; }
 public virtual DateTime DateDue{ get; set; } 

Rental(Book b, DateTime DateRented, DateTime DateDue)
{
  DateRented = DateTime.Today;
}

}