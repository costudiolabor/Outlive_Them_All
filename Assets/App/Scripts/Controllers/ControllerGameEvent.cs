using System;
using UnityEngine;

[Serializable]
public class ControllerGameEvent : IDisposable
{
    [SerializeField] private PanelGameEvent panelGameEvent;
    
    public event Action NextEvent;
    
    public void Initialize() {
        Subscription();
        panelGameEvent.Initialize();
    }

    public void Show() {
        panelGameEvent.Show();
    }

    public void Hide() {
        panelGameEvent.Hide();
    }
    
    private void Subscription() {
        panelGameEvent.NextEvent += OnNext;
    }
    
    public void SetName(string name) {
        panelGameEvent.SetName(name);
    }
    
    public void SetDescription(string description) {
        panelGameEvent.SetDescription(description);
    }
    
    private void OnNext() {
        NextEvent?.Invoke();
        Hide();
    }
    

    public void Dispose() {
        NextEvent = null;
    }
}
