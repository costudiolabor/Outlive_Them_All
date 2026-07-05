using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelRight : View {
    [SerializeField] private RectTransform contentListSurvivors;
    [SerializeField] private Text listSurvivors;
    [SerializeField] private Text endingDescription;
    
    [SerializeField] private Button buttonRules;
    [SerializeField] private Button buttonMenu;
    [SerializeField] private Button buttonSound;

    public event Action RulesEvent, MenuEvent, SoundEvent;
    
    public void Initialize(DataGame dataGame) {
        Subscription();
    }

    private void Subscription() {
        buttonRules.onClick.AddListener(OnRules);
        buttonMenu.onClick.AddListener(OnMenu);
        buttonSound.onClick.AddListener(OnSound);
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
    
    public void UpdateListSurvivors(string value) {
        listSurvivors.text = value;
    }

    public void SetEndingDescription(string value) {
        endingDescription.text = value;
    }

    private void OnDestroy() {
        UnSubscription();
    }

    private void UnSubscription() {
        buttonRules.onClick.RemoveAllListeners();
        buttonMenu.onClick.RemoveAllListeners();
        buttonSound.onClick.RemoveAllListeners();
        RulesEvent = null;
        MenuEvent = null;
        SoundEvent = null;
    }
    
}
