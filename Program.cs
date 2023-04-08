// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Microsoft;

RokuganMap map = new RokuganMap();

string path = "C:\\Users\\sedasanc\\CSProjects\\Rokugan Battle Map\\save";
while (true)
{
    DrawRokuganMap(map);
    UpdateArmiesMovement(map);

    // Pause the loop for a while, e.g., using Thread.Sleep(milliseconds)
    Thread.Sleep(30*1000);

    Thread.Sleep(30*1000);
}
