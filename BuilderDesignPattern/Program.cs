using BuilderDesignPattern.Builders.ProductBuilders;
using BuilderDesignPattern;

var gamingComputerBuilder = new GamingComputerBuilder();
var officeComputerBuilder = new OfficeComputerBuilder();

var gamingDirector = new ComputerDirector(gamingComputerBuilder);
gamingDirector.ConstructComputer();

var officeDirector = new ComputerDirector(officeComputerBuilder);
officeDirector.ConstructComputer();

var gamingComputer = gamingDirector.GetComputer();

Console.WriteLine(
        $"RAM : {gamingComputer.RAM} " +
        $"CPU : {gamingComputer.CPU} " +
        $"GPU : {gamingComputer.GPU} " +
        $"Storage : {gamingComputer.Storage} ");