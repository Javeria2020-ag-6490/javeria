using System;

namespace New_folder__2_
{
   public class Person
    {
        public string FirstName;
          public string LastName;
          public void Introduce()
          {
        Console.WriteLine("my name is " + FirstName +" " + LastName);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
        Person javeria = new Person();
        }
    }
}
