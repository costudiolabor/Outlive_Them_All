using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class ControllerCreatePlayers {
    [SerializeField] private PanelCreatePlayers panelCreatePlayers;
    [SerializeField] private PlayerUI playerPrefab;

    private ControllerCreateGame _controllerCreateGame;
    public event Action NextEvent, BackEvent;
    
    public List<PlayerUI> players = new List<PlayerUI>();
    public void Initialize(ControllerCreateGame controllerCreateGame) {
        Subscription();
        panelCreatePlayers.Initialize();
        _controllerCreateGame = controllerCreateGame;
    }

    public void CreatePlayers() {
        DestroyPlayers();
        int numPlayers = _controllerCreateGame.CountPlayers;
        RectTransform parent = panelCreatePlayers.Content;
        for (int i = 0; i < numPlayers; i++)
        {
            PlayerUI player = Object.Instantiate(playerPrefab, parent);
            int numPlayer = i + 1;
            player.Initialize(numPlayer);
            players.Add(player);
        }
    }
    
    public void DestroyPlayers() {
        foreach (var t in players) {
            Object.Destroy(t.gameObject);
        }
        players.Clear();
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
