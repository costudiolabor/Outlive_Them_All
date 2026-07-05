using UnityEngine;

public static class PersonExtensions
{
    public static Person GetRandomByGender(this Person[] persons, Gender gender)
    {
        if (persons == null || persons.Length == 0) return null;
        
        // Если запрашивают Trans - возвращаем случайного из всех (любого пола)
        if (gender == Gender.Trans)
        {
            return persons[Random.Range(0, persons.Length)];
        }
        
        // Для Male и Female - фильтруем строго по полу
        var filtered = System.Array.FindAll(persons, p => p.gender == gender);
        
        if (filtered.Length == 0)
        {
            Debug.LogWarning($"Нет персонажей с полом {gender}");
            return null;
        }
        
        return filtered[Random.Range(0, filtered.Length)];
    }
}