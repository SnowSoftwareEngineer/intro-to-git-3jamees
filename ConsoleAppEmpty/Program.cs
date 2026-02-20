using GameEnums;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a difficulty (Easy, Medium, Hard):");
        GameDifficulty difficulty;
        Enum.TryParse(Console.ReadLine(), true, out difficulty);

        Console.WriteLine();
        Console.WriteLine("Select a character class (Warrior, Mage, Rogue):");
        CharacterClass characterClass;
        Enum.TryParse(Console.ReadLine(), true, out characterClass);

        Console.WriteLine();
        Console.WriteLine("You selected:");
        Console.WriteLine("Difficulty: " + difficulty);
        Console.WriteLine("Character Class: " + characterClass);
    }
}