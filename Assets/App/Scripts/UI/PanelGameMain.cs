using UnityEngine;
using UnityEngine.UI;

public class PanelGameMain : View {
    [SerializeField] private Text numberRound;
    [SerializeField] private Text numberPlayer;
    [SerializeField] private Text namePlayer;
    
    [SerializeField] RawImage iconPlayer;
    [SerializeField] private Text characteristic;
    
    [SerializeField] private Button buttonBio;
    [SerializeField] private Button buttonHealth;
    [SerializeField] private Button buttonBaggage;
    [SerializeField] private Button buttonProfession;
    [SerializeField] private Button buttonCharacter;
    [SerializeField] private Button buttonPhobia;
    [SerializeField] private Button buttonKnowledge;
    
    
    [SerializeField] private Button buttonRandomEvent;
    [SerializeField] private RectTransform contentPlayers;
    [SerializeField] private Text timer;
    [SerializeField] private Button buttonNextStep;
    
    
    public RectTransform ContentPlayers => contentPlayers;
    
    
    public void Initialize() {
        Subscription();
    }
    
    private void Subscription() {
        buttonBio.onClick.AddListener(OnClickBio);
        buttonHealth.onClick.AddListener(OnClickHealth);
        buttonBaggage.onClick.AddListener(OnClickBaggage);
        buttonProfession.onClick.AddListener(OnClickProfession);
        buttonCharacter.onClick.AddListener(OnClickCharacter);
        buttonPhobia.onClick.AddListener(OnClickPhobia);
        buttonKnowledge.onClick.AddListener(OnClickKnowledge);
        buttonRandomEvent.onClick.AddListener(OnClickRandomEvent);
        buttonNextStep.onClick.AddListener(OnClickNextStep);
    }


    public void SetInfo(int numRound, int numPlayer, string name) {
        numberRound.text = numRound.ToString();
        numberPlayer.text = numPlayer.ToString();
        namePlayer.text = name;
    }

    public void SetIconPlayer(Sprite sprite) {
        iconPlayer.texture = sprite.texture;
    }

    public void SetTextCharacteristic(string value) { 
        characteristic.text = value;
    }

    public void SetTimer(string value) {
        timer.text = value;
    }
    
    private void OnClickKnowledge() {
        
    }

    private void OnClickPhobia() {
        
    }

    private void OnClickCharacter() {
        
    }

    private void OnClickProfession() {
        
    }

    private void OnClickBaggage() {
        
    }

    private void OnClickHealth() {
        
    }

    private void OnClickBio() {
        
    }

    private void OnClickNextStep() {
        
    }

    private void OnClickRandomEvent() {
        
    }
    
    private void OnDestroy() {
        UnSubscription();
    }

    private void UnSubscription() {
      
    }
    
}
