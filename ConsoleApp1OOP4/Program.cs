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
    }
    }
}
