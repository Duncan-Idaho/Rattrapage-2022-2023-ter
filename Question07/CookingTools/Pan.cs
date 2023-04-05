namespace Question07.Console.CookingTools;

public class Pan : CookingContainer
{
    public Pan(Logger logger) : base(logger)
    {
    }

    public async Task<Food> CookGreaseSide()
    {
        Log("Cooking grease side");
        await Task.Delay(700);

        Transform(from: Food.DuckBreast, to: new[]
        {
            Food.DuckBreastPartiallyCooked,
            Food.DuckGrease,
        });
        Log("Cooked grease side");

        return Extract(Food.DuckGrease);
    }

    public async Task<Food> CookMeatSide()
    {
        Log("Cooking meat side");
        await Task.Delay(700);

        Transform(from: Food.DuckBreastPartiallyCooked, to: Food.CookedDuckBreast);
        Log("Meat side cooked");

        return ExtractRemaining();
    }


    public async Task<Food> CookPotatoes()
    {
        Log("Cooking potatoes");
        await Task.Delay(2000);

        Transform(from: new[]
        {
            Food.Potatoes,
            Food.DuckGrease,
        }, to: Food.CookePotatoes);
        Log("Cooked potatoes");

        return ExtractRemaining();
    }
}
