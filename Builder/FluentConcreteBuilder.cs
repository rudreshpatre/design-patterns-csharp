namespace Builder
{
    public class FluentConcreteBuilder:IFluentBuilder
    {
        private Product _product = new Product();
        public FluentConcreteBuilder()
        {
            this.Reset();
        }

        public IFluentBuilder BuildPartA()
        {
            this._product.Add("PartAFLuent");
            return this;
        }

        public IFluentBuilder BuildPartB()
        {
            this._product.Add("PartBFluent");
            return this;
        }

        public IFluentBuilder BuildPartC()
        {
            this._product.Add("PartCFLuent");
            return this;
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public Product GetProducts()
        {
            var result = this._product;
            this.Reset();
            return result;
        }
    }
}