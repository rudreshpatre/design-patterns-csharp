namespace Builder
{
    public interface IFluentBuilder
    {
        IFluentBuilder BuildPartA();
        IFluentBuilder BuildPartB();
        IFluentBuilder BuildPartC();
        Product GetProducts();
    }
}