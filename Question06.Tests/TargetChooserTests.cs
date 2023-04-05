using Question06.Console;

namespace Question06.Tests;

public class TargetChooserTests
{
    [Fact]
    public void WritePromisingCitiies()
    {
        var expected = @"Berlin (Europe)
-> 858454 in Berlin for Kingston in London
-> 76540 in Berlin for Ingersleben in Berlin
-> 910187 in Berlin for Bourdillon in Paris
-> 26000 in Berlin for Farran in London
Lisbon (Europe)
-> 345556 in Lisbon for Beaumont in Paris
-> 317231 in Lisbon for Abt in Berlin
-> 697894 in Lisbon for Fukui in Tokyo
-> 106117 in Lisbon for Schubert in Berlin
-> 904533 in Lisbon for Farran in London
-> 183473 in Lisbon for Haase in Berlin
-> 720144 in Lisbon for Ramires in Lisbon
-> 283208 in Lisbon for Ramires in Lisbon
Paris (Europe)
-> 821578 in Paris for Julien in Paris
-> 607041 in Paris for Bourdillon in Paris
-> 292911 in Paris for Haase in Berlin
-> 36993 in Paris for Thorburn in London
-> 549977 in Paris for Phelps in London
-> 475105 in Paris for Haase in Berlin
-> 246372 in Paris for Kingston in London
London (Europe)
-> 723103 in London for Schubert in Berlin
-> 131702 in London for Ramires in Lisbon
-> 805043 in London for Magalhães in Lisbon
-> 377033 in London for Schubert in Berlin
";

        var stringWriter = new StringWriter();
        var chooser = new TargetChooser(stringWriter);
        chooser.WriteMostPromisingCities(Data.Bounties);

        Assert.Equal(expected, stringWriter.ToString());
    }
}