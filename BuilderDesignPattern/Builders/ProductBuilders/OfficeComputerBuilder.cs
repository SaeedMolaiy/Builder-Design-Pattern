namespace BuilderDesignPattern.Builders.ProductBuilders;

internal class OfficeComputerBuilder : ComputerBuilder
{
    public override void SetCpu()
    {
        Computer.CPU = "Mid-range office CPU";
    }

    public override void SetRam()
    {
        Computer.RAM = "8GB DDR4";
    }

    public override void SetStorage()
    {
        Computer.Storage = "1TB HDD";
    }

    public override void SetGpu()
    {
        Computer.GPU = "Integrated GPU";
    }
}