using System;
  
  class Person
  {   //instructor-given class given to inherit from.
        //Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        

        public Person() 
        {
          //Console.WriteLine("Person constructor");
        }

        public Person(string fname, string lname, string email) 
        {
          FirstName = fname;
          LastName = lname;
          Email = email;
          Console.WriteLine("Person constructor with parameters");
        }

        public virtual void Intro()
        {
            Console.WriteLine("Hello my name is *** "+ FirstName +" "+ LastName);
        }

        public void IsBirthday()
        {
          if ((DateTime.Today.Month == DateOfBirth.Month)&&(DateTime.Today.Day == DateOfBirth.Day))
            Console.WriteLine("It's your birthday!!!");
          else
            Console.WriteLine("Today is not your birthday.");
        }

      
    }