using System;
using UnityEngine;

[Serializable]
public class ControllerPanelGame {
    [SerializeField] private PanelGame panelGame;
    
    
    public void Initialize() {
        Subscription();
        panelGame.Initialize();
    }

    public void Show() {
        panelGame.Show();
    }

    public void Hide() {
        panelGame.Hide();
    }
    
    private void Subscription() {
        
    }
    
    
}
