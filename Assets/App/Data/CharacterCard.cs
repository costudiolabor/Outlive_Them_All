using System;
[Serializable]
public class CharacterCard {
    public GenderData genderData;
}


[Serializable]
public class GenderData {
    public string name;
    public int value;
}
//public void Setup 
//characterCard.ge
// Использование:
// GenderData[] data = new GenderData[]
// {
//     new GenderData { Name = "Мужчина", Value = 0 },
//     new GenderData { Name = "Женщина", Value = 0 },
//     new GenderData { Name = "Трансгендер", Value = 0 }
// };



[Serializable]
public class AgeGroup {
    public int minAge;
    public int maxAge;
    public int value;
    public bool ContainsAge(int age) { return age >= minAge && age <= maxAge; }
}

// Создание массива:
// AgeGroup[] ageGroups = new AgeGroup[]
// {
//     new AgeGroup(10, 15, -2),
//     new AgeGroup(16, 25, 1),
//     new AgeGroup(26, 40, 3),
//     new AgeGroup(41, 60, 1),
//     new AgeGroup(61, 80, -2)
// };
//
// // Пример использования:
// int playerAge = 30;
// foreach (var group in ageGroups)
// {
//     if (group.ContainsAge(playerAge))
//     {
//         Debug.Log($"Бонус для возраста {playerAge}: {group.value}");
//         break;
//     }
// }
