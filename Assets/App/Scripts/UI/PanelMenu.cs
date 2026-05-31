using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelMenu : View {
    [SerializeField] private Button buttonContinue;
    [SerializeField] private Button buttonCreateGame;
    [SerializeField] private Button buttonRules;
    
    public event Action CreateGameEvent, RulesEvent;
    
    public void Initialize() {
        Subscription();
        ActiveContinue(false);
    }

    private void Subscription() {
        buttonContinue.onClick.AddListener(OnContinue);
        buttonCreateGame.onClick.AddListener(OnCreateGame);
        buttonRules.onClick.AddListener(OnRules);
    }

    public void ActiveContinue(bool isActive) {
        buttonCreateGame.gameObject.SetActive(!isActive);
        buttonContinue.gameObject.SetActive(isActive);
    }

    private void OnContinue() {
        Hide();
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
        buttonContinue.onClick.RemoveAllListeners();
        buttonCreateGame.onClick.RemoveAllListeners();
        buttonRules.onClick.RemoveAllListeners();
        CreateGameEvent = null;
        RulesEvent = null;
        
    }
    
}
