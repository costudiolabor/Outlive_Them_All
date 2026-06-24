using System;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class ControllerCreatePlayers {
    [SerializeField] private PanelCreatePlayers panelCreatePlayers;
    [SerializeField] private PlayerUI playerPrefab;
    private DataGame _dataGame;
    private DataCharacter _dataCharacter;
    public event Action NextEvent, BackEvent;
    public void Initialize(DataGame dataGame, DataCharacter dataCharacter) {
        _dataGame = dataGame;
        _dataCharacter = dataCharacter;
        Subscription();
        panelCreatePlayers.Initialize();
        
    }

    public void CreatePlayers() {
        DestroyPlayers();
        int numPlayers = _dataGame.CountPlayers;
        RectTransform parent = panelCreatePlayers.Content;
        for (int i = 0; i < numPlayers; i++)
        {
            PlayerUI player = Object.Instantiate(playerPrefab, parent);
            int numPlayer = i + 1;
            player.Initialize(numPlayer);
            player.PlayerNickname = "Игрок " + numPlayer;
            _dataGame.Players.Add(player);
            
            int scenario = _dataGame.ScenarioCount;
            
            CharacterCard characterCard = _dataCharacter.GetCharacterCard(scenario);
            player.CharacterCard = characterCard;
        }
    }
    
    
    
    public void DestroyPlayers() {
        foreach (var t in _dataGame.Players) {
            Object.Destroy(t.gameObject);
        }
        _dataGame.Players.Clear();
    }
    
    public void Show() {
        panelCreatePlayers.Show();
    }

    public void Hide() {
        panelCreatePlayers.Hide();
    }

    
    private void Subscription() {
        panelCreatePlayers.BackEvent += OnBack;
        panelCreatePlayers.NextEvent += OnNext;
    }
    
    
    private void OnNext() {
        NextEvent?.Invoke();
    }
    
    private void OnBack() {
        BackEvent?.Invoke();
    }
    
    
    public void Dispose() {
        BackEvent = null;
        NextEvent = null;
    }
    
}
