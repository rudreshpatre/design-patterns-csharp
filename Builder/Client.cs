namespace Builder
{
    using System;
    public class Client
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Hello I am Client :-)");
            // Create object using constructor
            Console.WriteLine("Create objects using constructor");
            var product = new Product();
            product.Add("Part A");
            product.Add("Part B");
            product.Add("Part C");
            Console.WriteLine(product.ListParts()); 

            Console.WriteLine();
            Console.WriteLine("Create objects using Builder object");
             // Create Object using Builder object
             var builder = new ConcreteBuilder();
             var director = new Director();
             director.Builder = builder;

             director.BuildMinimalViableProduct();
             Console.WriteLine(builder.GetProduct().ListParts());

             director.BuildFullFeaturedProduct();
             Console.WriteLine(builder.GetProduct().ListParts());

             builder.BuildPartA();
             builder.BuildPartC();
             Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine();
            Console.WriteLine("Create objects using Fluent Builder object");

            var fluentBuilder = new FluentConcreteBuilder();
            Console.WriteLine(fluentBuilder.BuildPartB()
                                           .BuildPartC()
                                           .BuildPartA()
                                           .BuildPartB()
                                           .GetProducts().ListParts());
             
        }
    }
}