using FluentAssertions;

namespace HelloDotnetCLI.Test.Test;

public class UnitTest1
{
    [Trait("Category", "1 - Crie um novo projeto de console")]
    [Fact]
    public void TestCreatedConsoleApplication()
    {
        var act = () => Program.Main(new string[] { });
        act.Should().NotThrow();
    }
}