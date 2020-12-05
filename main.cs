using System;

class MainClass {
  public static void Main (string[] args) {
//START PART 1
    //creating book objects
    Book book1 = new Book("11223344","Legend of Drizzt: Homecoming", "R.A. Salvatore");
    Book book2 = new Book("6958490", "The Lion, The Witch, and The Audacity", "Shel B. Cominround");
    Book book3 = new Book("8675309", "Legend of Drizzt: Wulfgar", "R.A. Salvatore");
    Book book4 = new Book("13121312", "Werner Herzogs Wary Hog", "Shel B. Cominround", Convert.ToDateTime("10/02/1997"), "Walrus Publishing");
    Book book5 = new Book("5415424", "Legend of Drizzt: Cattie-Brie", "R.A. Salvatore", Convert.ToDateTime("12/05/1999"), "Gatehouse Books");
    Book book6 = new Book("9875421", "I Ran Out of Book Titles", "Shel B. Cominround", Convert.ToDateTime("10/4/2015"), "Walrus Publishing");
    
    //creating author objects
    Author a1 = new Author("R.A.", "Salvatore", "fakeemail213@gmail.com");
    Author a2 = new Author("Shel B.", "Cominround", "realemail1312@gmail.com");
    
    //Author intros
    a1.DisplayInfo();
    a2.DisplayInfo();
    
    //book displays - testing purposes only
    /*
    book1.Display();
    book2.Display();
    book3.Display();
    book4.Display();
    book5.Display();
    book6.Display();
    

    //Author Book Lists - testing purposes only
    a1.DisplayBooks();
    a2.DisplayBooks();
    */

    //Adding books to Authors BookLists & Displaying them
    a1.AddBook(book1);
    a1.AddBook(book3);
    a1.AddBook(book5);
    a1.DisplayBooks();
    a2.AddBook(book2);
    a2.AddBook(book4);
    a2.AddBook(book6);
    a2.DisplayBooks();

    //Removing book1 from a1
    a1.RemoveBook("11223344");

    //Displaying Author 1's Books again
    a1.DisplayBooks();
//END PART 1
//START PART 2
    //Creating Patrons
    Patron p1 = new Patron("Jim", "Jones", "7777");
    Patron p2 = new Patron("Shoko", "Asahara", "8888");
    Patron p3 = new Patron("Brigham", "Young", "9999");
    Patron p4 = new Patron("Ed", "Gein", "1111");
    Patron p5 = new Patron("Marshall", "Applewhite", "2222");

    //Adding Book1 to Patron1's rental cart using AddToRentalCart();
    p1.AddToRentalCart(book1, Convert.ToDateTime("10/2/2021"));

    //Removing Book3 from Patron1's rental cart using RemoveFromRentalCart();
    p1.RemoveFromRentalCart(book3);

  
    //Displaying Patron Info - Test Purposes only
    /*
    p1.Display();
    p2.Display();
    p3.Display();
    p4.Display();
    p5.Display();
    */

//END PART 2
//START PART 3
  LibraryCollection lc1 = new LibraryCollection();
  //I wanted to do something like this:
  //foreach (var Patron in PatronList)
  //{
  // lc1.AddPatron(p);  
  //}
  //but I couldnt figure out how to access that list in from main.cs
  lc1.AddPatron(p1);
  lc1.AddPatron(p2);
  lc1.AddPatron(p3);
  lc1.AddPatron(p4);
  lc1.AddPatron(p5);
  lc1.DisplayPatronInfo();
  lc1.RemovePatron(p5);
  lc1.DisplayPatronInfo();
  //same story with adding these books, couldnt figure out how to access it. im sure the answer is really simple.
  lc1.AddToCollection(book1);
  lc1.AddToCollection(book2);
  lc1.AddToCollection(book3);
  lc1.AddToCollection(book4);
  lc1.AddToCollection(book5);
  lc1.AddToCollection(book6);
  lc1.DisplayCollection();
  lc1.RemoveFromCollection(book5);
  lc1.DisplayCollection();

  p1.AddToRentalCart(book1, Convert.ToDateTime("12/12/2012"));
  p1.AddToRentalCart(book2, Convert.ToDateTime("12/13/2012"));
  p1.AddToRentalCart(book3, Convert.ToDateTime("12/14/2012"));
  p1.RemoveFromRentalCart(book3);
  lc1.ProcessRental(p1);
  lc1.DisplayCollection();
  //lc1.ProcessReturns(book2, p1);
  //lc1.DisplayCollection();
  //END PART 3
  }
}