namespace ConsoleApp1OOP4
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            // static binding :Static binding means the method call is resolved at compile time.
            // it does in compile time when have method overriding , method hiding , static and private method.
            //class Animal
            //{
            //public static void Speak()
            //{
            //    Console.WriteLine("Animal sound");
            //}
            //dynamic binding:Dynamic binding means the method call is resolved at runtime based on the actual object.
            //it does in runtime when have virtual method,overriding method , interfacecalls
            //class Animal
            //{
            //public virtual void Speak()
            //{
            //    Console.WriteLine("Animal sound");
            //}
            //}

            //class Dog : Animal
            //{
            //public override void Speak()
            //{
            //    Console.WriteLine("Dog barks");
            //}
            //}

            #endregion
            #region Q2
            //Method overloading means having multiple methods with the same name but different parameters in the same class.
            //compile time polymorphism(static binding)
            //class Calculator
            //{
            //public int Add(int a, int b)
            //{
            //    return a + b;
            //}

            //public int Add(int a, int b, int c)
            //{
            //    return a + b + c;
            //}
            //}
            //method overriding means Derived class overrides a virtual method from the base class using the override keyword.
            //run time polymorphisme(dynamic binding)
            //class Animal
            //{
            //public virtual void Speak()
            //{
            //    Console.WriteLine("Animal sound");
            //}
            //}

            //class Dog : Animal
            //{
            //public override void Speak()
            //{
            //    Console.WriteLine("Dog barks");
            //}
            //}

            #endregion
            #region Q3
            //1. virtual  :used with parent class to can Allow a method to be overridden in a derived class.
            //and means this method can change in derived class
            //class Animal
            //{
            //public virtual void Speak()
            //{
            //    Console.WriteLine("Animal sound");
            //}
            //}
            //2. override :used with derived class and can replace the parent class implementation and change the parent method behavior
            //class Dog : Animal
            //{
            //public override void Speak()
            //{
            //    Console.WriteLine("Dog barks");
            //}
            //}
            #endregion
            Cinema cinema = new Cinema("Galaxy Cinema");
            cinema.OpenCinema();
            StandardTicket t1 = new StandardTicket("Inception", "A-5");
            VIPTicket t2 = new VIPTicket("Avengers", true, 50);
            IMAXTicket t3 = new IMAXTicket("Dune", false);
            Console.WriteLine("\n========= SetPrice Test =========");
            t1.Setprice(150);
            Console.WriteLine("Setting price directly: 150");
            t2.Setprice(100, 1.5m);
            Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");
            t3.Setprice(180);
            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);
            cinema.PrintAllTickets();
            Cinema.ProcessTicket(t2);
            cinema.CloseCinema();
        }
    }
}
