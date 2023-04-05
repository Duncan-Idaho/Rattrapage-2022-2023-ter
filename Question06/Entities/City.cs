namespace Question06.Console.Entities;

public record City(string Name, RegionName Region)
{
    public static City Paris = new City("Paris", RegionName.Europe);
    public static City Tokyo = new City("Tokyo", RegionName.Asia);
    public static City London = new City("London", RegionName.Europe);
    public static City Berlin = new City("Berlin", RegionName.Europe);
    public static City Lisbon = new City("Lisbon", RegionName.Europe);
}
