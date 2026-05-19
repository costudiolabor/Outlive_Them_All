using System;
using UnityEngine;

[Serializable]
public class ControllerMain : IDisposable{
    
    [SerializeField] private ControllerMenu controllerMenu;
    [SerializeField] private ControllerRules controllerRules;
    [SerializeField] private ControllerCreateGame controllerCreateGame;
    [SerializeField] private ControllerCreatePlayers controllerCreatePlayers;

    public void Initialize() {
        controllerMenu.Initialize();
        controllerRules.Initialize();
        controllerCreateGame.Initialize();
        controllerCreatePlayers.Initialize();
        Subscription();
    }

    private void Subscription() {
        controllerMenu.CreateGameEvent += OnCreateGame;
        controllerMenu.RulesEvent += OnRules;
        controllerRules.BackEvent += OnBackRules;
        controllerCreateGame.NextEvent += OnCreatePlayers;
        controllerCreateGame.BackEvent += OnBackCreateGame;
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
        controllerCreatePlayers.Show();
    }
    
    private void OnBackCreateGame() {
        controllerCreateGame.Hide();
        controllerMenu.Show();
    }

    public void Dispose() {
        controllerMenu.Dispose();
        controllerRules.Dispose();
        controllerCreateGame.Dispose();
    }
    
}
