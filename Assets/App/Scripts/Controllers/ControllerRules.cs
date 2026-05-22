using System;
using UnityEngine;

[Serializable]
public class ControllerRules : IDisposable {
    [SerializeField] private PanelRules panelRules;
    
    public event Action BackEvent;
    public void Initialize() {
        panelRules.Initialize();
        Subscription();
    }
    
    public void Show() {
        panelRules.Show();
    }

    public void Hide() {
        panelRules.Hide();
    }

    private void Subscription() {
        panelRules.BackEvent += OnBack;
    }
    
    private void OnBack() {
        BackEvent?.Invoke();
    }

    public void Dispose() {
       BackEvent = null;
    }
    
}
