using System;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "DataIconPerson", menuName = "ScriptableObjects/DataIconPerson", order = 1)]
[Serializable]
public class DataIconPerson : ScriptableObject
{
    public IconPerson[] icons = new IconPerson[] { };
}
