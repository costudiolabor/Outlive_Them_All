using System;
using UnityEngine;
using System.Linq;

public static class ScenarioExtensions
{
    public static T GetRandomByScenario<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Массив пуст");
            return default;
        }
        var filtered = items.Where(item => scenarioSelector(item) == scenarioNumber).ToArray();

        if (filtered.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Нет элементов для сценария {scenarioNumber}");
            return default;
        }
        return filtered[UnityEngine.Random.Range(0, filtered.Length)];
    }
    
    public static T[] GetAllByScenario<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Массив пуст");
            return new T[0];
        }

        return items.Where(item => scenarioSelector(item) == scenarioNumber).ToArray();
    }
    public static T GetRandom<T>(this T[] items)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning($"[ScenarioExtensions] Массив пуст");
            return default;
        }

        return items[UnityEngine.Random.Range(0, items.Length)];
    }

    public static bool HasScenarioItems<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0) return false;
        return items.Any(item => scenarioSelector(item) == scenarioNumber);
    }
    
    public static int CountByScenario<T>(this T[] items, int scenarioNumber, System.Func<T, int> scenarioSelector)
    {
        if (items == null || items.Length == 0) return 0;
        return items.Count(item => scenarioSelector(item) == scenarioNumber);
    }
}