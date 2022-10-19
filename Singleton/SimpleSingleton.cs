namespace Singleton
{
    using System;

    // singleton class should be sealed
    public sealed class SimpleSingleton
    {
        // private static singleton variable
        private static SimpleSingleton instance = null;
       
        // constructor should be private
        private SimpleSingleton(){}

        // public method for accessing the instance
        // lazy initialization of instance,only intialise the singleton variable,when requested
        public static SimpleSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new SimpleSingleton();
                Value = new Guid();
            }
            return instance;
        }
        private static Guid Value { get; set; }
        // Any business logic
        public string BusinessLogic()
        {
            return "Business Logic :"+Value;
        }
         
    }
}