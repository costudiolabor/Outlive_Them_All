using System;
using UnityEngine;

[Serializable]
public class ControllerMain : IDisposable{
    
    [SerializeField] private ControllerMenu controllerMenu;
    [SerializeField] private ControllerRules controllerRules;
    [SerializeField] private ControllerCreateGame controllerCreateGame;
    [SerializeField] private ControllerCreatePlayers controllerCreatePlayers;
    [SerializeField] private ControllerNextPlayer controllerNextPlayer;
    [SerializeField] private ControllerPanelGame controllerPanelGame;

    public void Initialize() {
        controllerMenu.Initialize();
        controllerRules.Initialize();
        controllerCreateGame.Initialize();
        controllerCreatePlayers.Initialize(controllerCreateGame);
        controllerNextPlayer.Initialize();
        controllerPanelGame.Initialize();
        Subscription();
    }

    private void Subscription() {
        controllerMenu.CreateGameEvent += OnCreateGame;
        controllerMenu.RulesEvent += OnRules;
        controllerRules.BackEvent += OnBackRules;
        
        controllerCreateGame.NextEvent += OnCreatePlayers;
        controllerCreateGame.BackEvent += OnBackCreateGame;
        
        controllerCreatePlayers.NextEvent += OnGame;
        controllerCreatePlayers.BackEvent += OnBackCreatePlayers;
    }
    

    private void OnCreateGame() {
        controllerMenu.Hide();
        controllerCreateGame.Show();
    }
    
    private void OnRules() {
        controllerMenu.Hide();
        controllerRules.Show();
    }
    
    private void OnBackRules() {
        controllerRules.Hide();
        controllerMenu.Show();
    }
    
    private void OnCreatePlayers() {
        controllerCreateGame.Hide();
        controllerCreatePlayers.CreatePlayers();
        controllerCreatePlayers.Show();
    }
    
    private void OnBackCreateGame() {
        controllerCreateGame.Hide();
        controllerMenu.Show();
    }
    
    private void OnGame() {
        controllerCreatePlayers.Hide();
        controllerPanelGame.Show();
    }
    
    private void OnBackCreatePlayers() {
        controllerCreatePlayers.Hide();
        controllerCreateGame.Show();
    }
    
    
    
    
    
    public void Dispose() {
        controllerMenu.Dispose();
        controllerRules.Dispose();
        controllerCreateGame.Dispose();
    }
    
}
