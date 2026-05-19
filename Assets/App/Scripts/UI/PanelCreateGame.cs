using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelCreateGame : View  {
    [SerializeField] private TMP_Text countPlayers;
    [SerializeField] private Slider slider;
    [SerializeField] private Button buttonNext;
    [SerializeField] private Button buttonBack;

    public event Action NextEvent, BackEvent;
    public event Action<int> SliderEvent;
   
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        slider.onValueChanged.AddListener(OnValueChanged);
        buttonNext.onClick.AddListener(OnNext);
        buttonBack.onClick.AddListener(OnBack);
        int sliderValue = (int)slider.value;
        SetCountPlayers(sliderValue);
        SliderEvent?.Invoke(sliderValue);
    }

    public void SetCountPlayers(float count) {
        countPlayers.text = count.ToString();
    }
    
    private void OnValueChanged(float value) {
        SetCountPlayers(value);
        SliderEvent?.Invoke((int)value);
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
        slider.onValueChanged.RemoveAllListeners();
        buttonNext.onClick.RemoveAllListeners();
        buttonBack.onClick.RemoveAllListeners();
        NextEvent = null;
        BackEvent = null;
    }

}
