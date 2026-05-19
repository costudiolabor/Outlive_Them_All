using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelRules : View {
    [SerializeField] private Button buttonBack;
    
    public event Action BackEvent;
    
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        buttonBack.onClick.AddListener(OnBack);
    }
    
    private void OnBack() {
        BackEvent?.Invoke();
    }

    private void OnDestroy() {
        buttonBack.onClick.RemoveAllListeners();
        BackEvent = null;
    }
    
}
