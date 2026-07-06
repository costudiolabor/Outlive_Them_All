using System;
using UnityEngine;

[Serializable]
public class ControllerMain : IDisposable
{
    [SerializeField] private ControllerMenu controllerMenu;
    [SerializeField] private ControllerRules controllerRules;
    [SerializeField] private ControllerCreateGame controllerCreateGame;
    [SerializeField] private ControllerCreatePlayers controllerCreatePlayers;
    [SerializeField] private ControllerGameMain controllerGameMain;
    [SerializeField] private ControllerNextPlayer controllerNextPlayer;
    [SerializeField] private ControllerGameEvent controllerGameEvent;

    private DataGame _dataGame;
    public void Initialize(SettingGame settingGame, DataGame dataGame, DataCharacter dataCharacter)
    {
        _dataGame = dataGame;
        StartNewGame(dataGame);
        controllerMenu.Initialize();
        string rules = dataGame.Rules;
        controllerRules.Initialize(rules);
        controllerCreateGame.Initialize(settingGame, dataGame);
        controllerCreatePlayers.Initialize(dataGame, dataCharacter);
        controllerNextPlayer.Initialize();
        controllerGameEvent.Initialize();
        Subscription();
    }

    private void StartNewGame(DataGame dataGame) {
        dataGame.StartNewGame();
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
    }

    private void OnCreateGame() {
        controllerMenu.Hide();
        controllerCreateGame.Show();
    }
    
    private void OnRules() {
        controllerRules.Show();
    }
    
    private void OnBackRules() {
        controllerRules.Hide();
    }
    
    private void OnCreatePlayers() {
        controllerCreateGame.Hide();
        controllerCreatePlayers.CreatePlayers();
        controllerCreatePlayers.Show();
        
        controllerGameMain.Initialize(_dataGame);
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
