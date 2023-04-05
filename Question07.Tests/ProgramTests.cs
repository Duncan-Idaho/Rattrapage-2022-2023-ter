using Question07.Console;

namespace Question07.Tests;

public class ProgramTests
{
    [Fact]
    public async Task GoodSequence()
    {
        var result = @"[T + 000] Cooking grease side with DuckBreast
[T + 007] Cooked grease side with DuckGrease,DuckBreastPartiallyCooked
[T + 007] Cooking potatoes with Potatoes,DuckGrease
[T + 007] Cooking meat side with DuckBreastPartiallyCooked
[T + 014] Meat side cooked with CookedDuckBreast
[T + 027] Cooked potatoes with CookePotatoes
[T + 027] Eating with CookedDuckBreast,CookePotatoes
";

        var stringWriter = new StringWriter();
        var kitchen = new Kitchen(stringWriter);
        var meal = kitchen.PrepareMeal();
        meal.Eat();
        Assert.Equal(result, stringWriter.ToString());
    }

}
