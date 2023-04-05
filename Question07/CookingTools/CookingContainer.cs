using System.Collections.Concurrent;

namespace Question07.Console.CookingTools;

public class CookingContainer
{
    private readonly ConcurrentDictionary<Food, int> content = new();
    private readonly Logger logger;

    public CookingContainer(Logger logger)
    {
        this.logger = logger;
    }

    protected void Log(string logLine)
        => logger.Log(logLine + " with " + Content);

    private string Content
        => string.Join(",", content.Select(pair => pair.Key).OrderBy(food => food));

    public void Add(Food food)
        => content.AddOrUpdate(food, 1, (_, oldValue) => oldValue + 1);

    protected Food Extract(Food food)
    {
        if (!content.TryRemove(food, out var count))
            throw new InvalidOperationException($"Can't remove {food} because there's none");

        if (count != 1)
            throw new InvalidOperationException($"Can't remove {food} because there's more than one");

        return food;
    }

    protected Food ExtractRemaining()
        => Extract(content.Single().Key);

    protected void Transform(Food[] from, Food[] to)
    {
        foreach (var fromFood in from)
            Extract(fromFood);

        foreach (var toFood in to)
            Add(toFood);
    }

    protected void Transform(Food from, Food[] to)
        => Transform(new[] { from }, to);

    protected void Transform(Food[] from, Food to)
        => Transform(from, new[] { to });

    protected void Transform(Food from, Food to)
        => Transform(new[] { from }, new[] { to });
}