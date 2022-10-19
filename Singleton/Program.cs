namespace Singleton
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
           LineBreak();
           SimpleSingletonImplementation();
           LineBreak();
        }

        private static void LineBreak()
        {
            Console.WriteLine("-------------------------------------");
        }

        private static void SimpleSingletonImplementation()
        {
            Console.WriteLine("    >> Simple Singleton <<");

           var instanceOne = SimpleSingleton.GetInstance();
           var instanceTwo = SimpleSingleton.GetInstance();

           if (String.Equals(instanceOne.BusinessLogic,instanceTwo.BusinessLogic))
           {
               Console.WriteLine("Singleton works, both variables contain the same instance.");
           }
           else
           {  
               Console.WriteLine("Singleton failed, variables contain different instances.");
           }
        }
    }
}