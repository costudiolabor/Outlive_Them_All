using System;
using UnityEngine;

[Serializable]
public class ControllerCreatePlayers {
    [SerializeField] private PanelCreatePlayers panelCreatePlayers;
    public void Initialize() {
        panelCreatePlayers.Initialize();
    }
    
    
    public void Show() {
        panelCreatePlayers.Show();
    }

    public void Hide() {
        panelCreatePlayers.Hide();
    }

    
}
