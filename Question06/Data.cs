using Question06.Console.Entities;

namespace Question06.Console;

public static class Data
{
    public static readonly Person[] Persons = new[]
    {
        new Person("Cyril", "Marchand", new DateTime(1987, 5, 6), City.Paris),
        new Person("Vivienne", "Bourdillon", new DateTime(1989, 5, 1), City.Paris),
        new Person("Eddy", "Beaumont", new DateTime(2013, 9, 7), City.Paris),
        new Person("Ernest", "Julien", new DateTime(1986, 4, 27), City.Paris),
        new Person("Sybille", "Lefebvre", new DateTime(1994, 11, 20), City.Paris),
        new Person("Aya", "Fukui", new DateTime(1995, 7, 7), City.Tokyo),
        new Person("Masao", "Matsumura", new DateTime(2008, 12, 31), City.Tokyo),
        new Person("Ryo", "Mori", new DateTime(2000, 2, 24), City.Tokyo),
        new Person("Saori", "Kusumoto", new DateTime(1993, 3, 5), City.Tokyo),
        new Person("Yoshirou", "Shimada", new DateTime(2006, 12, 16), City.Tokyo),
        new Person("Justy", "Moss", new DateTime(1989, 8, 27), City.London),
        new Person("Maybelline", "Phelps", new DateTime(2006, 3, 2), City.London),
        new Person("Petunia", "Kingston", new DateTime(1975, 2, 22), City.London),
        new Person("Dacre", "Thorburn", new DateTime(1983, 11, 15), City.London),
        new Person("Karter", "Farran", new DateTime(2005, 9, 5), City.London),
        new Person("Leonard", "Rot", new DateTime(2019, 6, 6), City.Berlin),
        new Person("Karl", "Haase", new DateTime(1987, 8, 28), City.Berlin),
        new Person("Abraham", "Abt", new DateTime(1979, 5, 19), City.Berlin),
        new Person("Verena", "Ingersleben", new DateTime(1987, 8, 31), City.Berlin),
        new Person("Hedwig", "Schubert", new DateTime(1977, 3, 28), City.Berlin),
        new Person("Verónica", "Almeida", new DateTime(1998, 9, 17), City.Lisbon),
        new Person("Dora", "Ramires", new DateTime(2018, 2, 23), City.Lisbon),
        new Person("Mónica", "Freitas", new DateTime(1991, 10, 21), City.Lisbon),
        new Person("Álvaro", "Magalhães", new DateTime(2016, 11, 17), City.Lisbon),
        new Person("Rogério", "Correia", new DateTime(1978, 11, 16), City.Lisbon),
    };

    public static readonly Bounty[] Bounties = new[]
    {
        new Bounty(Persons[3], 821578, Danger.Hard, City.Paris, true),
        new Bounty(Persons[1], 607041, Danger.Low, City.Paris, false),
        new Bounty(Persons[19], 723103, Danger.Impossible, City.London, true),
        new Bounty(Persons[12], 858454, Danger.Hard, City.Berlin, false),
        new Bounty(Persons[2], 345556, Danger.Medium, City.Lisbon, true),
        new Bounty(Persons[17], 317231, Danger.Medium, City.Lisbon, true),
        new Bounty(Persons[0], 87582, Danger.Medium, City.Tokyo, false),
        new Bounty(Persons[5], 697894, Danger.Medium, City.Lisbon, false),
        new Bounty(Persons[18], 76540, Danger.Impossible, City.Berlin, false),
        new Bounty(Persons[1], 910187, Danger.Low, City.Berlin, true),
        new Bounty(Persons[21], 131702, Danger.Hard, City.London, false),
        new Bounty(Persons[16], 292911, Danger.Impossible, City.Paris, false),
        new Bounty(Persons[23], 805043, Danger.Low, City.London, true),
        new Bounty(Persons[19], 377033, Danger.Medium, City.London, false),
        new Bounty(Persons[19], 106117, Danger.Hard, City.Lisbon, false),
        new Bounty(Persons[13], 36993, Danger.Low, City.Paris, false),
        new Bounty(Persons[9], 311862, Danger.Low, City.Tokyo, true),
        new Bounty(Persons[14], 904533, Danger.Hard, City.Lisbon, false),
        new Bounty(Persons[11], 549977, Danger.Impossible, City.Paris, false),
        new Bounty(Persons[16], 183473, Danger.Impossible, City.Lisbon, false),
        new Bounty(Persons[21], 720144, Danger.Hard, City.Lisbon, true),
        new Bounty(Persons[21], 283208, Danger.Hard, City.Lisbon, true),
        new Bounty(Persons[16], 475105, Danger.Low, City.Paris, true),
        new Bounty(Persons[12], 246372, Danger.Hard, City.Paris, false),
        new Bounty(Persons[14], 26000, Danger.Impossible, City.Berlin, false),
    };
}
