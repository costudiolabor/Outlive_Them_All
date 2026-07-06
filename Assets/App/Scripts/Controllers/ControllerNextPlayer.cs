using System;
using UnityEngine;

[Serializable]
public class ControllerNextPlayer : IDisposable{
    [SerializeField] private PanelNextPlayer panelNextPlayer;
    
    public event Action NextEvent;
    
    public void Initialize() {
        Subscription();
        panelNextPlayer.Initialize();
    }

    public void Show() {
        panelNextPlayer.Show();
    }

    public void Hide() {
        panelNextPlayer.Hide();
    }
    
    private void Subscription() {
        panelNextPlayer.NextEvent += OnNext;
    }
    
    public void SetNamePlayer(string name) {
        panelNextPlayer.SetNamePlayer(name);
    }
    
    private void OnNext() {
        NextEvent?.Invoke();
        Hide();
    }
    

    public void Dispose() {
        NextEvent = null;
    }
}
