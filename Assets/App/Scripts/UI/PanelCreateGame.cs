using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelCreateGame : View  {
    [SerializeField] private TMP_Text countPlayers;
    [SerializeField] private Slider slider;
    
    [SerializeField] private Button buttonOn;
    [SerializeField] private Button buttonOff;
    [SerializeField] private Image imageOn;
    [SerializeField] private Image imageOff;
     
    [SerializeField] private Button button1Min;
    [SerializeField] private Button button2Min;
    [SerializeField] private Button button5Min;
    [SerializeField] private TMP_Text timer;
    [SerializeField] private Button buttonMinus10Sec;
    [SerializeField] private Button buttonPlus10Sec;
    
    [SerializeField] private Button buttonNext;
    [SerializeField] private Button buttonBack;

    public event Action<bool> StateTimerEvent;
    public event Action NextEvent, BackEvent;
    public event Action<int> SliderEvent, ChangeTimerEvent;
   
    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        slider.onValueChanged.AddListener(OnValueChanged);
        
        buttonOn.onClick.AddListener(OnTimer);
        buttonOff.onClick.AddListener(OffTimer);
        
        button1Min.onClick.AddListener(On1Min);
        button2Min.onClick.AddListener(On2Min);
        button5Min.onClick.AddListener(On5Min);
        
        buttonMinus10Sec.onClick.AddListener(OnMinus10Sec);
        buttonPlus10Sec.onClick.AddListener(OnPlus10Sec);
        
        buttonNext.onClick.AddListener(OnNext);
        buttonBack.onClick.AddListener(OnBack);
        
        int sliderValue = (int)slider.value;
        SetCountPlayers(sliderValue);
        SliderEvent?.Invoke(sliderValue);
        OnTimer();

    }

    private void OnTimer() {
        StateTimerEvent?.Invoke(true);
        imageOn.enabled = true;
        imageOff.enabled = false;
    } 
    
    private void OffTimer() {
        StateTimerEvent?.Invoke(false);
        imageOff.enabled = true;
        imageOn.enabled = false;
    }

    public void SetTimer(string value) {
        timer.text = value;
    }
    
    private void On1Min() {
        ChangeTimerEvent?.Invoke(60);
    }

    private void On2Min() {
        ChangeTimerEvent?.Invoke(120);
    }

    private void On5Min() {
        ChangeTimerEvent?.Invoke(300);
    }

    private void OnMinus10Sec() {
        ChangeTimerEvent?.Invoke(-10);
    }

    private void OnPlus10Sec() {
        ChangeTimerEvent?.Invoke(10);
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
        
        buttonOn.onClick.RemoveAllListeners();
        buttonOff.onClick.RemoveAllListeners();
        
        button1Min.onClick.RemoveAllListeners();
        button2Min.onClick.RemoveAllListeners();
        button5Min.onClick.RemoveAllListeners();
        buttonMinus10Sec.onClick.RemoveAllListeners();
        buttonPlus10Sec.onClick.RemoveAllListeners();

        StateTimerEvent = null;
        SliderEvent = null;
        ChangeTimerEvent = null;

        NextEvent = null;
        BackEvent = null;
    }

}
