public enum Action
{
    TrainUnit,
    BuyEquipment,
    CreateUnit,
    IncreaseUnitNumber,
    SendUnitsToCity,
    AttackCity,
}

public interface IClanAI
{
    Action ChooseAction(Clan clan, Game game);
    // Add any additional methods necessary for AI decision-making
}

public class CrabClanAI : IClanAI
{
    // Implement Crab Clan AI logic
}

public class CraneClanAI : IClanAI
{
    // Implement Crane Clan AI logic
}

// ... and so on for each Clan



public class Game
{
    public List<Clan> Clans { get; set; }

    public Game()
    {
        Clans = new List<Clan>();
        // Initialize Clans with their respective AI classes
    }

    public void PlayGame()
    {
        while (true) // Replace with a condition that checks for the end of the game
        {
            foreach (Clan clan in Clans)
            {
                Action action = clan.AI.ChooseAction(clan, this);
                // Execute the chosen action
            }
        }
    }
}
