using Question07.Console.CookingTools;

namespace Question07.Console;

public class Kitchen
{
    private readonly Logger logger;

    private readonly Pan duckPan;
    private readonly Pan potatoePan;

    public Kitchen(TextWriter logOutput)
    {
        logger = new Logger(logOutput);

        duckPan = new Pan(logger);
        potatoePan = new Pan(logger);
    }

    public Plate PrepareMeal()
    {
        duckPan.Add(Food.DuckBreast);
        var grease = duckPan.CookGreaseSide().Result;

        potatoePan.Add(grease);
        potatoePan.Add(Food.Potatoes);
        var potatoes = potatoePan.CookPotatoes().Result;
        var duck = duckPan.CookMeatSide().Result;

        var plate = new Plate(logger);
        plate.Add(potatoes);
        plate.Add(duck);
        return plate;
    }
}
