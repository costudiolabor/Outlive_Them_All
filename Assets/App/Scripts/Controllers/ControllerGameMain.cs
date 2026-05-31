using System;
using UnityEngine;

[Serializable]
public class ControllerGameMain : IDisposable{
    [SerializeField] private PanelGameParent panelGameParent;
    [SerializeField] private PanelGameMain panelGameMain;
    [SerializeField] private PanelLeft panelLeft;
    [SerializeField] private PanelRight panelRight;
    
    public event Action RulesEvent, MenuEvent, SoundEvent;
    public void Initialize() {
        Subscription();
        panelGameParent.Initialize();
        panelGameMain.Initialize();
        panelLeft.Initialize();
        panelRight.Initialize();
        panelRight.RulesEvent += OnRules;
        panelRight.MenuEvent += OnMenu;
        panelRight.SoundEvent += OnSound;
    }
    
    private void OnRules() {
        RulesEvent?.Invoke();
    }

    private void OnMenu() {
        MenuEvent?.Invoke();
    }

    private void OnSound() {
        SoundEvent?.Invoke();
    }

    

    public void Show() {
        panelGameParent.Show();
    }

    public void Hide() {
        panelGameParent.Hide();
    }
    
    private void Subscription() {
        
    }


    public void Dispose() {
        RulesEvent = null;
        MenuEvent = null;
        SoundEvent = null;
    }
    
}
