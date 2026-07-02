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
        panelLeft.Initialize(dataGame);
        panelRight.Initialize(dataGame);
    }

    private void Subscription()
    {
        panelGameMain.BioEvent += OnClickBio;
        panelGameMain.HealthEvent += OnClickHealth;
        panelGameMain.BaggageEvent  += OnClickBaggage;
        panelGameMain.ProfessionEvent  += OnClickProfession;
        panelGameMain.CharacterEvent  += OnClickCharacter;
        panelGameMain.PhobiaEvent  += OnClickPhobia;
        panelGameMain.KnowledgeEvent  += OnClickKnowledge;
        panelGameMain.RandomEvent  += OnClickRandomEvent;
        panelGameMain.NextEvent += OnClickNextStep;
        
        panelRight.RulesEvent += OnRules;
        panelRight.MenuEvent += OnMenu;
        panelRight.SoundEvent += OnSound;
    }

    public void SettingGame() {
        int sec = _dataGame.CurrentTimer;
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
        int round = _dataGame.Round;
        int numberPlayer = _dataGame.GetNumberPlayer();
        string namePlayer = _dataGame.GetNamePlayer();
        Texture icon = _dataGame.GetCharacterCard().iconPerson.icon;
        panelGameMain.SetInfo(round, numberPlayer, namePlayer);
        panelGameMain.SetIconPlayer(icon);
    }

    private void CreateButtonsPlayers() {
        int numPlayers = _dataGame.CountPlayers;
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
        _dataGame.CurrentIndexPlayer = indexPlayer;
        ShowInfo();
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Имя: {characterCard.person.name}\n" +
                                $"Фамилия: {characterCard.surName.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }
    
    private void OnClickKnowledge() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Знания: {characterCard.knowledge.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickPhobia() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Фобия: {characterCard.phoBia.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickCharacter() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Характер: {characterCard.personalityTrait.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickProfession() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Профессия: {characterCard.profession.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickBaggage() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Снаряжение: {characterCard.equipment.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickHealth() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"Здоровье: {characterCard.healthTrait.name}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickBio() {
        CharacterCard characterCard = _dataGame.GetCharacterCard();
        string characteristic = $"пол: {characterCard.gender.name}\n" +
                                $"Возраст: {characterCard.ageGroup.minAge}\n";
        panelGameMain.SetTextCharacteristic(characteristic);
    }

    private void OnClickNextStep() {
        
    }

    private void OnClickRandomEvent() {
        
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
