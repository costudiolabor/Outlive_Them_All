using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DataIconPerson", menuName = "ScriptableObjects/DataIconPerson", order = 1)]
[Serializable]
public class DataIconPerson : ScriptableObject
{
    public IconPerson[] icons = new IconPerson[] { };
}
