using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelNextPlayer : View {
    [SerializeField] private Text namePlayer;
    [SerializeField] private Button buttonNext;
    
    public event Action NextEvent;
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        buttonNext.onClick.AddListener(OnNext);
    }

    public void SetNamePlayer(string name) {
        namePlayer.text = name;
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
