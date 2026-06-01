using System;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class ControllerCreatePlayers {
    [SerializeField] private PanelCreatePlayers panelCreatePlayers;
    [SerializeField] private PlayerUI playerPrefab;
    private DataGame _dataGame;
    public event Action NextEvent, BackEvent;
    public void Initialize(DataGame dataGame) {
        _dataGame = dataGame;
        Subscription();
        panelCreatePlayers.Initialize();
        
    }

    public void CreatePlayers() {
        DestroyPlayers();
        int numPlayers = _dataGame.countPlayers;
        RectTransform parent = panelCreatePlayers.Content;
        for (int i = 0; i < numPlayers; i++)
        {
            PlayerUI player = Object.Instantiate(playerPrefab, parent);
            int numPlayer = i + 1;
            player.Initialize(numPlayer);
            player.PlayerNickname = "Игрок " + numPlayer;
            _dataGame.players.Add(player);
        }
    }
    
    
    
    public void DestroyPlayers() {
        foreach (var t in _dataGame.players) {
            Object.Destroy(t.gameObject);
        }
        _dataGame.players.Clear();
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
