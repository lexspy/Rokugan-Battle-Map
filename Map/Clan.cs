using System.Drawing;
using System;

public enum ClanType
{
    Military, Aristocrat, Religious, Sovereign, Naval, Academic, Espionage, Merchant, Criminal
}


public class Clan 
{    
    public string Name { get; set; }    
    public Color EmblemColor { get; set; }    
    public ClanType Type { get; set; }        
    public int MightValue { get; set; }    
    public int WealthValue { get; set; }    
    public int InfluenceValue { get; set; }    
    public int IntrigueValue { get; set; }    
    public int KnowledgeValue { get; set; }    
    public int MightMod => (MightValue - 10) / 2;    
    public int WealthMod => (WealthValue - 10) / 2;    
    public int InfluenceMod => (InfluenceValue - 10) / 2;    
    public int IntrigueMod => (IntrigueValue - 10) / 2;    
    public int KnowledgeMod => (KnowledgeValue - 10) / 2;    
    public int Scope { get; set; } = 2;    
    public int Structure => Math.Max(MightMod, Math.Max(WealthMod, Math.Max(InfluenceMod, Math.Max(IntrigueMod, KnowledgeMod)))) + Scope;    
    public int MaxStability => 25 + Structure;    
    public int CurrentStability { get; set; }    
    public int CurrentPlotPoints { get; set; }
    public IClanAI AI { get; set; }

    public Clan(string name, Color emblemColor, ClanType type)
    {
        Name = name;
        EmblemColor = emblemColor;
        CurrentStability = MaxStability;
        CurrentPlotPoints = 0;
    }

    public Clan(string name, Color emblemColor, ClanType type, IClanAI ai) : this(name, emblemColor, type)
    {
        AI = ai;
    }
}
