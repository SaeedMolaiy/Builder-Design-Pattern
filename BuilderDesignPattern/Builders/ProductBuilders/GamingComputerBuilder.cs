namespace BuilderDesignPattern.Builders.ProductBuilders;

internal class GamingComputerBuilder : ComputerBuilder
{
    public override void SetCpu()
    {
        Computer.CPU = "High-end gaming";
    }

    public override void SetRam()
    {
        Computer.RAM = "16GB DDR4";
    }

    public override void SetStorage()
    {
        Computer.Storage = "512GB SSD";
    }

    public override void SetGpu()
    {
        Computer.GPU = "NVIDIA RTX 3080";
    }
}