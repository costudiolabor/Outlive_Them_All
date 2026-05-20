using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelCreatePlayers : View {
    [SerializeField] private RectTransform content;
    [SerializeField] private Button buttonNext;
    [SerializeField] private Button buttonBack;
    
    public RectTransform Content => content;
    public event Action NextEvent, BackEvent;
    
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        buttonNext.onClick.AddListener(OnNext);
        buttonBack.onClick.AddListener(OnBack);
    }
    
    
    private void OnNext() {
        NextEvent?.Invoke();
    }
    
    private void OnBack() {
        BackEvent?.Invoke();
    }
    
    private void OnDestroy() {
        UnSubscription();
    }

    private void UnSubscription() {
        buttonNext.onClick.RemoveAllListeners();
        buttonBack.onClick.RemoveAllListeners();
        NextEvent = null;
        BackEvent = null;
    }

}
