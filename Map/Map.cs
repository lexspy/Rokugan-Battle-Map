using System.Drawing;

public class RokuganMap
{
    public List<Castle> Castles { get; set; }
    public List<Army> Armies { get; set; }





    public RokuganMap()
    {
        Castles = new List<Castle>();
        Armies = new List<Army>();
    }
    public RokuganMap(List<Castle> castles, List<Army> armies)
    {
        Castles = castles;
        Armies = armies;
    }

    public RokuganMap InitializeRokuganMap()
    {
        return new RokuganMap(Castles,Armies);
    }

    public void DrawRokuganMap(RokuganMap map)
    {
        // Draw the map with castles and armies
        // ...
    }

    public void UpdateArmiesMovement(RokuganMap map)
    {
        // Update the positions of armies on the map based on their targets
        // ...
    }

    public List<Castle> GenerateCastles(List<Clan> clans)
    {
        Dictionary<string, List<string>> clanSubregions = new Dictionary<string, List<string>>
        {
            { "Crab", new List<string> { "Kyuden Kuni", "Shiro Kuni", "Wall Above the Ocean Village", "Kyuden Hida", "Shiro Hiruma", "Razor of the Dawn Castle", "Kyuden Kaiu", "Shiro Kaiu", "Iron Mine", "Friendly Traveler Village", "Shutai", "Lonely Shore City" } },
            { "Crane", new List<string> { "Kyuden Doji", "Shiro no Yojin", "Cold Wind City", "Kyuden Kakita", "Shiro sano Kakita", "Tsuma Village", "Kyuden Daidoji", "Kosaten Shiro", "Mura Sabishii Toshi", "Kyuden Asahina", "Shiro Hanamidoki", "Morning Frost Castle" } },
            { "Dragon", new List<string> { "Kyuden Togashi", "Shiro Kitsuki", "Last Step Castle", "Kyuden Mirumoto", "Shiro Mirumoto", "Heibeisu", "Kyuden Kitsuki", "Toi Koku", "Dragon's Guard City", "Kyuden Tamori", "Shiro Tamori", "Great Falls Castle" } },
            { "Lion", new List<string> { "Kyuden Akodo", "Shiro Akodo", "Tonfajutsen", "Kyuden Matsu", "Shiro no Yojin", "Rugashi", "Kyuden Ikoma", "Shiro Ikoma", "Mura ni Konda Toshi", "Kyuden Kitsu", "Shiro Kitsu", "Bishamon Seido" } },
            { "Mantis", new List<string> { "Kyuden Gotei", "Shiro Yoritomo", "Toshi no Inazuma", "Kyuden Ashinagabachi", "Shiro Tsuruchi", "Nesting Swallow Castle", "Kyuden Moshi", "Shiro Moshi", "Amaterasu Seido" } },
            { "Phoenix", new List<string> { "Kyuden Shiba", "Shiro Shiba", "Shiro Gisu", "Kyuden Isawa", "Shiro Isawa", "Reihaido Isawa", "Kyuden Asako", "Shiro Asako", "Nikesake" } },
            { "Scorpion", new List<string> { "Kyuden Bayushi", "Shiro no Shosuro", "Beiden Pass", "Kyuden Shosuro", "Shiro Shosuro", "Ryoko Owari Toshi", "Kyuden Yogo", "Shiro Yogo", "Zakyo Toshi", "Kyuden Soshi", "Shiro Soshi", "Pokau" } },
            { "Unicorn", new List<string> { "Kyuden Shinjo", "Shiro Shinjo", "Far North Village", "Kyuden Moto", "Shiro Moto", "Endless Plain Village", "Kyuden Ide", "Shiro Ide", "City of the Rich Frog", "Kyuden Iuchi", "Shiro Iuchi", "Dark Edge Village" } }
            // Add remaining clan subregions
        };

        List<Castle> castles = new List<Castle>();

        foreach (Clan clan in clans)
        {
            if (clanSubregions.TryGetValue(clan.Name, out List<string>? subregions))
            {
                foreach (string subregion in subregions)
                {
                    Castle castle = new Castle(subregion, new Coordinate { X = 0, Y = 0 }, clan);

                    castles.Add(castle);
                }
            }
        }

        return castles;
    }
    public List<Clan> InitializeClans()
    {
        List<Clan> clans = new List<Clan>
        {
            new Clan("Crab", Color.Blue),
            new Clan("Crane", Color.LightBlue),
            new Clan("Dragon", Color.Green),
            new Clan("Lion", Color.Yellow),
            new Clan("Mantis", Color.Teal),
            new Clan("Phoenix", Color.OrangeRed),
            new Clan("Scorpion", Color.DarkRed),
            new Clan("Unicorn", Color.Pink),
            new Clan("Renegade", Color.Black)
        };

        return clans;
    }
}

public class Castle
{
    

    public string Name { get; set; }
    public Coordinate Location { get; set; }
    public Clan Owner { get; set; }

    public Castle(string name, Coordinate location, Clan owner)
    {
        Name = name;
        Location = location;
        Owner = owner;
    }
}

public class Army
{
    public string Name { get; set; }
    public int NumberOfBattalions { get; set; }
    public General General { get; set; }
    public Clan Affiliation { get; set; }
    public Castle TargetCastle { get; set; }

    public Army(string name, int numberOfBattalions, General general, Castle targetCastle)
    {
        Name = name;
        NumberOfBattalions = numberOfBattalions;
        General = general;
        Affiliation = general.Affiliation;
        TargetCastle = targetCastle;
    }
}

public class General
{
    public string Name { get; set; }
    public bool IsRogue { get; set; }
    public Clan Affiliation { get; set; }

    public General(string name, bool isRogue, Clan clan)
    {
        Name = name;
        IsRogue = isRogue;
        Affiliation = clan;
    }
}

public struct Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }
}