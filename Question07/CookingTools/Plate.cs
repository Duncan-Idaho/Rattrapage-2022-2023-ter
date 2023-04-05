namespace Question07.Console.CookingTools;

public class Plate : CookingContainer
{
    public Plate(Logger logger) : base(logger)
    {
    }

    public void Eat()
    {
        Log("Eating");
        Extract(Food.CookePotatoes);
        Extract(Food.CookedDuckBreast);
    }
}
