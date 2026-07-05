using UnityEngine;
using System.Linq;

public static class RaceDataExtensions
{
    public static RaceData GetRandomByScenario(this RaceData[] items, int scenarioCount)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("[RaceDataExtensions] Массив пуст");
            return null;
        }

        var filtered = items.Where(item => item.scenarioCount == scenarioCount).ToArray();

        if (filtered.Length == 0)
        {
            Debug.LogWarning($"[RaceDataExtensions] Нет данных для сценария {scenarioCount}");
            return null;
        }

        return filtered[Random.Range(0, filtered.Length)];
    }

    public static RaceData GetRandomByScenarioAndRace(this RaceData[] items, int scenarioCount, Race race)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("[RaceDataExtensions] Массив пуст");
            return null;
        }

        var filtered = items.Where(item => item.scenarioCount == scenarioCount && item.race == race).ToArray();

        if (filtered.Length == 0)
        {
            Debug.LogWarning($"[RaceDataExtensions] Нет данных для сценария {scenarioCount} и расы {race}");
            return null;
        }

        return filtered[Random.Range(0, filtered.Length)];
    }
    
    public static RaceData[] GetAllByScenario(this RaceData[] items, int scenarioCount)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("[RaceDataExtensions] Массив пуст");
            return new RaceData[0];
        }

        return items.Where(item => item.scenarioCount == scenarioCount).ToArray();
    }

    public static RaceData[] GetAllByScenarioAndRace(this RaceData[] items, int scenarioCount, Race race)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("[RaceDataExtensions] Массив пуст");
            return new RaceData[0];
        }

        return items.Where(item => item.scenarioCount == scenarioCount && item.race == race).ToArray();
    }

    public static RaceData GetRandom(this RaceData[] items)
    {
        if (items == null || items.Length == 0)
        {
            Debug.LogWarning("[RaceDataExtensions] Массив пуст");
            return null;
        }

        return items[Random.Range(0, items.Length)];
    }
}