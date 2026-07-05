using System.Linq;
using UnityEngine;

public static class IconPersonExtensions
{
    public static IconPerson GetRandomIcon(this IconPerson[] icons, 
        int scenarioCount, 
        Gender? gender = null, 
        Race? race = null,
        bool allowNull = false)
    {
        if (icons == null || icons.Length == 0)
        {
            Debug.LogWarning("Нет доступных иконок");
            return null;
        }

        var filtered = icons.Where(i => i.scenarioCount == scenarioCount);

        if (gender.HasValue)
            filtered = filtered.Where(i => i.gender == gender.Value);

        if (race.HasValue)
            filtered = filtered.Where(i => i.race == race.Value);

        var result = filtered.ToArray();

        if (result.Length == 0)
        {
            if (allowNull)
                return null;
            
            Debug.LogWarning($"Нет иконок для сценария {scenarioCount}, " +
                             $"пола {gender}, расы {race}");
            return null;
        }

        return result[Random.Range(0, result.Length)];
    }
    
}














// using System.Linq;
// using UnityEngine;
//
// public static class IconPersonExtensions
// {
//     /// <summary>
//     /// Получить случайную иконку с безопасной проверкой
//     /// </summary>
//     public static IconPerson GetRandomSafe(this IconPerson[] items,
//         int scenarioCount,
//         Gender? gender = null,
//         Race? race = null)
//     {
//         if (items == null || items.Length == 0)
//             return null;
//
//         var filtered = items.Where(i => i.scenarioCount == scenarioCount);
//
//         if (gender.HasValue)
//             filtered = filtered.Where(i => i.gender == gender.Value);
//
//         if (race.HasValue)
//             filtered = filtered.Where(i => i.race == race.Value);
//
//         var result = filtered.ToArray();
//
//         // Если ничего не найдено, пробуем получить без фильтра расы
//         if (result.Length == 0 && race.HasValue)
//         {
//             Debug.Log($"Нет иконок для {gender}/{race}, пробуем без расы");
//             return items.GetRandomByFilters(scenarioCount, gender, null);
//         }
//
//         // Если всё ещё ничего нет, пробуем только по сценарию
//         if (result.Length == 0)
//         {
//             Debug.Log($"Нет иконок для сценария {scenarioCount}, берём случайную");
//             return items.GetRandom();
//         }
//
//         return result[Random.Range(0, result.Length)];
//     }
//     
//     /// <summary>
//     /// Получить полностью случайную иконку из массива
//     /// </summary>
//     public static IconPerson GetRandom(this IconPerson[] items)
//     {
//         if (items == null || items.Length == 0)
//             return null;
//         
//         return items[Random.Range(0, items.Length)];
//     }
// }