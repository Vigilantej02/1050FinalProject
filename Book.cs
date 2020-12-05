using System;

class Book
{
public string ISBN {get; set;}
public string Title {get; set;}
public string AuthorInfo {get; set;}
public virtual DateTime PublishedOn {get; set;}
public string PublishedBy {get; set;}

public Book(string ISBN, string Title, string AuthorInfo)
{ 
  PublishedOn = DateTime.Today;
  PublishedBy = "Unknown.";
  //test case to see what constructor I was using v
  //Console.WriteLine("Book Constructor with ISBN, Title, AuthorInfo");
  //assigning parameters to variables to use in the Display() method
  this.ISBN = ISBN;
  this.Title = Title;
  this.AuthorInfo = AuthorInfo;
  
}

public Book(string ISBN, string Title, string AuthorInfo, DateTime PublishedOn, string PublishedBy)
{ //test case to see what constructor I was using v
  //Console.WriteLine("Book Constructor ISBN, Title, AuthorInfo, DateTime PublishedOn, PublishedBy");
  //assigning parameters to variables to use in the Display() method
  this.ISBN = ISBN;
  this.Title = Title;
  this.AuthorInfo = AuthorInfo;
  this.PublishedOn = PublishedOn;
  this.PublishedBy = PublishedBy;
}

public void Display()
{
 Console.WriteLine("The Book " + Title + " was written by " + AuthorInfo + " and published on " + PublishedOn);
}

}