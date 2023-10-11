using BuilderDesignPattern.Builders.ProductBuilders;
using BuilderDesignPattern.Products;

namespace BuilderDesignPattern;

internal class ComputerDirector
{
    private readonly ComputerBuilder builder;

    public ComputerDirector(ComputerBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructComputer()
    {
        builder.CreateComputer();
        builder.SetCpu();
        builder.SetRam();
        builder.SetStorage();
        builder.SetGpu();
    }

    public Computer GetComputer()
    {
        return builder.Computer;
    }
}