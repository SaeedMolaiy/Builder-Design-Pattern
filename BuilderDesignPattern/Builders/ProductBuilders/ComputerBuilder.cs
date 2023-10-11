using BuilderDesignPattern.Products;

namespace BuilderDesignPattern.Builders.ProductBuilders;

internal abstract class ComputerBuilder
{
    public Computer Computer { get; protected set; }

    public void CreateComputer()
    {
        Computer = new Computer();
    }

    public abstract void SetCpu();

    public abstract void SetRam();

    public abstract void SetStorage();

    public abstract void SetGpu();
}