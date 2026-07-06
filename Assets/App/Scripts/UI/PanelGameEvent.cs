using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelGameEvent : View {
    [SerializeField] private Text nameGameEvent;
    [SerializeField] private Text description;
    [SerializeField] private Button buttonNext;
    
    public event Action NextEvent;
    
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        buttonNext.onClick.AddListener(OnNext);
    }

    public void SetName(string nameEvent) {
        nameGameEvent.text = nameEvent;
    }
    
    public void SetDescription(string descriptionEvent) {
        nameGameEvent.text = descriptionEvent;
    }
    
    private void OnNext() {
        NextEvent?.Invoke();
    }
    
    private void OnDestroy() {
        UnSubscription();
    }

    private void UnSubscription() {
        buttonNext.onClick.RemoveAllListeners();
        NextEvent = null;
    }

}
