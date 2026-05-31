using System;
using UnityEngine;

[Serializable]
public class ControllerMenu : IDisposable{
    [SerializeField] private PanelMenu panelMenu;
    
    public event Action CreateGameEvent, RulesEvent;
    
    public void Initialize() {
        panelMenu.Initialize();
        Subscription();
    }
    
    public void ActiveContinue(bool isActive) {
        panelMenu.ActiveContinue(isActive);
    }

    public void Show() {
        panelMenu.Show();
    }

    public void Hide() {
        panelMenu.Hide();
    }
    
    private void Subscription()
    {
        panelMenu.CreateGameEvent += OnCreateGame;
        panelMenu.RulesEvent += OnRules;
    }
    
    private void OnCreateGame() {
        CreateGameEvent?.Invoke();
    }
    
    private void OnRules() {
        RulesEvent?.Invoke();
    }

    public void Dispose() {
        CreateGameEvent = null;
        RulesEvent = null;
    }
    
}
