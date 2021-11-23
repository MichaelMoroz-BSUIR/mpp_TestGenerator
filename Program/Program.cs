using TestGenerator;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var generator = NUnitTestGenerator.CreateGenerator(builder =>
            {
                builder.MaxGenerateFiles = 10;
                builder.MaxReadFiles = 10;
                builder.MaxWriteFiles = 10;
            });
            generator.GenerateTestsAsync(@"C:\Users\misha\RiderProjects\mpp_TestGenerator\Program\input",
                @"C:\Users\misha\RiderProjects\mpp_TestGenerator\Program\output").Wait();
        }
    }
}