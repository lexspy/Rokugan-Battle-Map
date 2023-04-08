using System.Drawing;

public class Clan
{
    public string Name { get; set; }
    public Color EmblemColor { get; set; }

    public Clan(string name, Color emblemColor)
    {
        Name = name;
        EmblemColor = emblemColor;
    }

    
}

