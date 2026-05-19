using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelMenu : View {
    [SerializeField] private Button buttonCreateGame;
    [SerializeField] private Button buttonRules;
    
    public event Action CreateGameEvent, RulesEvent;
    
    
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        buttonCreateGame.onClick.AddListener(OnCreateGame);
        buttonRules.onClick.AddListener(OnRules);
    }
    private void OnCreateGame() {
        CreateGameEvent?.Invoke();
    }
    
    private void OnRules() {
        RulesEvent?.Invoke();
    }

    private void OnDestroy() {
        UnSubscription();
    }

    private void UnSubscription() {
        buttonCreateGame.onClick.RemoveAllListeners();
        buttonRules.onClick.RemoveAllListeners();
        CreateGameEvent = null;
        RulesEvent = null;
    }
    
}
