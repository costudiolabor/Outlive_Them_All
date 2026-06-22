using UnityEngine;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Класс с методами расширения для работы со сценариями
/// </summary>
public static class ScenarioExtensions
{
    /// <summary>
    /// Получить случайный элемент из массива по номеру сценария
    /// </summary>
    /// <typeparam name="T">Тип элемента</typeparam>
    /// <param name="items">Массив элементов</param>
    /// <param name="scenarioNumber">Номер сценария</param>
    /// <param name="scenarioSelector">Функция, которая возвращает номер сценария из элемента</param>
    /// <returns>Случайный элемент или null/default</returns>
    public static T GetRandomByScenario<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Массив пуст");
            return default;
        }

        // Фильтруем элементы по сценарию
        var filtered = items.Where(item => scenarioSelector(item) == scenarioNumber).ToArray();

        if (filtered.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Нет элементов для сценария {scenarioNumber}");
            return default;
        }

        // Выбираем случайный
        return filtered[UnityEngine.Random.Range(0, filtered.Length)];
    }

    /// <summary>
    /// Получить все элементы для указанного сценария
    /// </summary>
    public static T[] GetAllByScenario<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Массив пуст");
            return new T[0];
        }

        return items.Where(item => scenarioSelector(item) == scenarioNumber).ToArray();
    }

    /// <summary>
    /// Получить случайный элемент из массива (без фильтрации)
    /// </summary>
    public static T GetRandom<T>(this T[] items)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Массив пуст");
            return default;
        }

        return items[UnityEngine.Random.Range(0, items.Length)];
    }

    /// <summary>
    /// Проверить, есть ли элементы для указанного сценария
    /// </summary>
    public static bool HasScenarioItems<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0) return false;
        return items.Any(item => scenarioSelector(item) == scenarioNumber);
    }

    /// <summary>
    /// Получить количество элементов для указанного сценария
    /// </summary>
    public static int CountByScenario<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0) return 0;
        return items.Count(item => scenarioSelector(item) == scenarioNumber);
    }
}