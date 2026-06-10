using System;
using UnityEngine;

[Serializable]
public class ControllerMain : IDisposable
{
    [SerializeField] private ControllerMenu controllerMenu;
    [SerializeField] private ControllerRules controllerRules;
    [SerializeField] private ControllerCreateGame controllerCreateGame;
    [SerializeField] private ControllerCreatePlayers controllerCreatePlayers;
    [SerializeField] private ControllerNextPlayer controllerNextPlayer;
    [SerializeField] private ControllerGameMain controllerGameMain;

    public void Initialize(SettingGame settingGame, DataGame dataGame)
    {
        ClearData(dataGame);
        controllerMenu.Initialize();
        controllerRules.Initialize();
        controllerCreateGame.Initialize(settingGame, dataGame);
        controllerCreatePlayers.Initialize(dataGame);
        controllerNextPlayer.Initialize();
        controllerGameMain.Initialize(dataGame);
        Subscription();
    }

    private void ClearData(DataGame dataGame) {
        dataGame.ClearData();
    }

    private void Subscription() {
        controllerMenu.CreateGameEvent += OnCreateGame;
        controllerMenu.RulesEvent += OnRules;
        controllerRules.BackEvent += OnBackRules;
        
        controllerCreateGame.NextEvent += OnCreatePlayers;
        controllerCreateGame.BackEvent += OnBackCreateGame;
        
        controllerCreatePlayers.NextEvent += OnGame;
        controllerCreatePlayers.BackEvent += OnBackCreatePlayers;
        
        controllerGameMain.RulesEvent += OnRules;
        controllerGameMain.MenuEvent += OnMenu;
    }
    
    
    private void OnMenu() {
        controllerMenu.ActiveContinue(true);
        controllerMenu.Show();
        //controllerRules.Show();
    }

    private void OnCreateGame() {
        controllerMenu.Hide();
        controllerCreateGame.Show();
    }
    
    private void OnRules() {
        //controllerMenu.Hide();
        controllerRules.Show();
    }
    
    private void OnBackRules() {
        controllerRules.Hide();
        //controllerMenu.Show();
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
        controllerGameMain.Show();
        controllerGameMain.SettingGame();
    }
    
    private void OnBackCreatePlayers() {
        controllerCreatePlayers.Hide();
        controllerCreateGame.Show();
    }
    
    public void Dispose() {
        controllerMenu.Dispose();
        controllerRules.Dispose();
        controllerCreateGame.Dispose();
        controllerCreatePlayers.Dispose();
        controllerNextPlayer.Dispose();
        controllerGameMain.Dispose();
        
        
    }
    
    
}
