using System.IO;
using Newtonsoft.Json;
public class SaveLoad
{
    public static void SaveObjectToFile<RokuganMap>(RokuganMap obj, string filePath)
    {
        string jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);
        File.WriteAllText(filePath, jsonString);
    }

    public static RokuganMap LoadObjectFromFile<RokuganMap>(string filePath)
    {
        if (!File.Exists(filePath))
            return default(RokuganMap);

        string jsonString = File.ReadAllText(filePath);
        RokuganMap obj = JsonConvert.DeserializeObject<RokuganMap>(jsonString);
        return obj;
    }
}