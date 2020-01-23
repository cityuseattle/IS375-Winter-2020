using System;

namespace Events
{
    public delegate string MyDel(string str);
    class Program
    {
        event MyDel MyEvent;

        public Program()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            string result = obj1.MyEvent("This is my first Event");
            Console.WriteLine(result);
        }
    }
}
