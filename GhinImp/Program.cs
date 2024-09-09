using GhinImp;

var characterGroup = new CharacterGroup();


characterGroup.AddCharacter("Diluc", "Pyro", 100, new Skill { SkillName = "Searing Onslaught", Damage = 200 });
characterGroup.AddCharacter("Mona", "Hydro", 80, new Skill { SkillName = "Mirror Reflection of Doom", Damage = 150 });
characterGroup.AddCharacter("Venti", "Anemo", 70, new Skill { SkillName = "Skyward Sonnet", Damage = 120 });

var attackCalculator = new AttackCalculator();

var powerfulCharacters = characterGroup.FilterCharacters(c => c.IsPowerful());

Console.WriteLine("Powerful Characters:");
foreach (var character in powerfulCharacters)
{
    Console.WriteLine($"Character: {character.Name}, Attack Power: {character.AttackPower}");
}

var highAttackers = characterGroup.FilterCharacters(c => attackCalculator.CalculateAverageAttack(c) > 80);

foreach (var character in highAttackers)
{
    Console.WriteLine(
        $"Character: {character.Name}, Average Attack: {attackCalculator.CalculateAverageAttack(character):F2}");
}

var sortedCharacters = characterGroup.SortCharactersByName;

foreach (var character in sortedCharacters)
{
    Console.WriteLine($"Character: {character.Name}");
}

Console.WriteLine($"Number of Pyro characters: {characterGroup.CountCharactersByElement("Pyro")}");

// Используем метод GetStrongestCharacter для нахождения персонажа с наибольшей силой атаки
var strongestCharacter = characterGroup.GetStrongestCharacter();
Console.WriteLine($"\nStrongest Character: {strongestCharacter.Name} with Attack Power: {strongestCharacter.AttackPower}");


// Используем метод FindCharacterByName для поиска персонажа по имени
var characterToFind = "Mona";
var foundCharacter = characterGroup.FindCharacterByName(characterToFind);
if (foundCharacter != null)
{
    Console.WriteLine($"\nFound Character: {foundCharacter.Name} with Element: {foundCharacter.Element} and Attack Power: {foundCharacter.AttackPower}");
    Console.WriteLine($"Total Skill Damage: {foundCharacter.CalculateTotalSkillDamage()}");
}
else
{
    Console.WriteLine($"\nCharacter '{characterToFind}' not found.");
}
