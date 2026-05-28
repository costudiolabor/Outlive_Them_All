using System;
using UnityEngine;

[Serializable]
public class ControllerCreateGame {
    [SerializeField] private PanelCreateGame panelCreateGame;
    private SettingGame _settingGame;
    private DataGame _dataGame;
    
    public event Action NextEvent, BackEvent;

    public void Initialize(SettingGame settingGame, DataGame dataGame) {
        _settingGame = settingGame;
        _dataGame = dataGame;
        Subscription();
        panelCreateGame.Initialize();
    }
    
    public void Show() {
        panelCreateGame.Show();
    }

    public void Hide() {
        panelCreateGame.Hide();
    }

    private void Subscription() {
        panelCreateGame.StateTimerEvent += OnStateTimer;
        panelCreateGame.ChangeTimerEvent += OnChangeTimer;
        panelCreateGame.SliderEvent += OnValueChanged;
        panelCreateGame.BackEvent += OnBack;
        panelCreateGame.NextEvent += OnNext;
    }

    private void OnStateTimer(bool state) {
        _dataGame.stateTimer = state;
    }
    
    private void OnChangeTimer(int sec) {
        _dataGame.currentTimer += sec;
        _dataGame.currentTimer = Mathf.Clamp(_dataGame.currentTimer, _settingGame.minTimer, _settingGame.maxTimer);
        int minutes = _dataGame.currentTimer / 60;
        int seconds = _dataGame.currentTimer % 60;
        string result = $"{minutes:00}:{seconds:00}";
        panelCreateGame.SetTimer(result);
    }
    
    private void OnValueChanged(int value) {
        _dataGame.countPlayers = value;
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