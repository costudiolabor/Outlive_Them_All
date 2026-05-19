using System;
using UnityEngine;

[Serializable]
public class ControllerCreateGame {
    [SerializeField] private PanelCreateGame panelCreateGame;
    
    public event Action NextEvent, BackEvent;

    private int countPlayers;

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
        panelCreateGame.SliderEvent += OnValueChanged;
        panelCreateGame.BackEvent += OnBack;
        panelCreateGame.NextEvent += OnNext;
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
