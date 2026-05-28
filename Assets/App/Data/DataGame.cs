using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DataGame", menuName = "ScriptableObjects/DataGame", order = 1)]
public class DataGame : ScriptableObject
{
    public bool stateTimer;
    public int currentTimer;
    public int countPlayers;
    public string nameGame;
    public string round;
    public int numberSeats;
    public List<PlayerUI> players = new List<PlayerUI>();
    
}
