using System;
using UnityEngine;

[Serializable]
public class ControllerCreateGame {
    [SerializeField] private PanelCreateGame panelCreateGame;
    
    private int countPlayers;
    private bool stateTimer;
    private int currentTimer;

    private const int minTimer = 0;
    private const int maxTimer = 1800;
    
    public int CountPlayers => countPlayers;
    public event Action NextEvent, BackEvent;

    public void Initialize() {
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
        stateTimer = state;
    }
    
    private void OnChangeTimer(int sec) {
        currentTimer += sec;
        currentTimer = Mathf.Clamp(currentTimer, minTimer, maxTimer);
        int minutes = currentTimer / 60;
        int seconds = currentTimer % 60;
        string result = $"{minutes:00}:{seconds:00}";
        panelCreateGame.SetTimer(result);
    }
    
    
    private void OnValueChanged(int value) {
        countPlayers = value;  
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
