namespace GhinImp;

// Record для хранения данных о персонаже

public record Character
{
    public string Name { get; init; }
    public string Element { get; }
    public int AttackPower { get; init; } //добавлить получение 
    public List<Skill> Skills;

    public Character(string name, string element, int attackPower, List<Skill> skills)
    {
        Name = name;
        Element = element;
        AttackPower = attackPower;
        Skills = skills;
    }

    // Метод для проверки силы атаки
    public bool IsPowerful()
    {
        return AttackPower > 80;
    }
    
    public int CalculateTotalSkillDamage()
    {
        int totalDamage = 0; //переменная счетчик 
        foreach (var skill in Skills)
        {
            totalDamage += skill.CalculateSkillDamage();
        }
        return totalDamage;
    }
}