using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class ControllerGameMain : IDisposable{
    [SerializeField] private PanelGameParent panelGameParent;
    [SerializeField] private PanelGameMain panelGameMain;
    [SerializeField] private PanelLeft panelLeft;
    [SerializeField] private PanelRight panelRight;
    [SerializeField] private ButtonPlayer buttonPlayerPrefab;

    private DataGame _dataGame;
    private List<ButtonPlayer> _buttonsPlayers = new List<ButtonPlayer>();
    public event Action RulesEvent, MenuEvent, SoundEvent;
    public void Initialize(DataGame dataGame) {
        _dataGame = dataGame;
        Subscription();
        panelGameParent.Initialize();
        panelGameMain.Initialize();
        panelLeft.Initialize();
        panelRight.Initialize();
    }

    private void Subscription() {
        panelRight.RulesEvent += OnRules;
        panelRight.MenuEvent += OnMenu;
        panelRight.SoundEvent += OnSound;
    }

    public void SettingGame() {
        int sec = _dataGame.currentTimer;
        ShowTimer(sec);
        ShowInfo();
        CreateButtonsPlayers();
    }
    
    public void ShowTimer(int sec) {
        int minutes = sec / 60;
        int seconds = sec % 60;
        string result = $"{minutes:00}:{seconds:00}";
        panelGameMain.SetTimer(result);
    }

    public void ShowInfo() {
        int round = _dataGame.round;
        int numberPlayer = _dataGame.GetNumberPlayer();
        string namePlayer = _dataGame.GetNamePlayer();
        panelGameMain.SetInfo(round, numberPlayer, namePlayer);
    }

    private void CreateButtonsPlayers() {
        int numPlayers = _dataGame.countPlayers;
        RectTransform parent = panelGameMain.ContentPlayers;
        for (int i = 0; i < numPlayers; i++) {
            ButtonPlayer buttonPlayer = Object.Instantiate(buttonPlayerPrefab, parent);
            int number = _dataGame.GetNumberPlayer(i);
            buttonPlayer.SetNumber(number);
            _buttonsPlayers.Add(buttonPlayer);
            int index = i;
            buttonPlayer.Button.onClick.AddListener(() => ClickButtonPlayer(index));
        }
    }

    private void ClickButtonPlayer(int indexPlayer) {
        Debug.Log(indexPlayer);
        _dataGame.currentIndexPlayer = indexPlayer;
        ShowInfo();
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

    private void RemoveAllListenersButtons() {
        for (int i = 0; i < _buttonsPlayers.Count; i++) {
            _buttonsPlayers[i].Button.onClick.RemoveAllListeners();
        }
    }
  

    public void Dispose() {
        RulesEvent = null;
        MenuEvent = null;
        SoundEvent = null;
        RemoveAllListenersButtons();
    }
    
}
