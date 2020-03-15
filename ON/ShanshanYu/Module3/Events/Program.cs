using System;

namespace Events
{
   public delegate string MyDel(string str);

   class Program
   {
      event MyDel MyEvent;
      event MyDel SecondEvent;

      public Program()
      {
         this.MyEvent += new MyDel(this.WelcomeUser);
         this.SecondEvent += new MyDel(this.Idontknow);
      }
  
      public string WelcomeUser(string username)
      {
         return "Welcome " + username;
      }
      public string Idontknow(string coursename)
      {
         return "Is " + coursename +" hard?";
      }
      static void Main(string[] args)
      {
         Program obj1 = new Program();
         string result = obj1.MyEvent("This is my first event.");
         string result2 = obj1.SecondEvent("C sharp");
         Console.WriteLine(result);
         Console.WriteLine(result2);
      }
   }
}
