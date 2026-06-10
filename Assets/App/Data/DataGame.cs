using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataGame", menuName = "ScriptableObjects/DataGame", order = 1)]
public class DataGame : ScriptableObject
{
    public bool stateTimer;
    public int currentTimer;
    public int countPlayers;
    public string nameGame;
    public int round;
    public int numberSeats;
    public int currentIndexPlayer;
    public List<PlayerUI> players = new List<PlayerUI>();
    
    public void ClearData() {
        stateTimer = false;
        currentTimer = 0;
        countPlayers = 0;
        nameGame = "";
        round = 1;
        numberSeats = 0;
        currentIndexPlayer = 0;
        players.Clear();
    }
    

    public int GetNumberPlayer() => players[currentIndexPlayer].number;
    public int GetNumberPlayer(int index) => players[index].number;
    public string GetNamePlayer() => players[currentIndexPlayer].PlayerNickname;

}




