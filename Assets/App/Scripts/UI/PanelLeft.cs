using UnityEngine;
using UnityEngine.UI;

public class PanelLeft : View {
    [SerializeField] private Text nameGame;
    [SerializeField] private Text descriptionGame;
    [SerializeField] private Text titleSafeZone;
    [SerializeField] private Text descriptionSafeZone;

    public void Initialize() {
        Subscription();
    }

    private void Subscription() {
        
    }
    
    public void SetNameGame(string value) {
        nameGame.text = value;
    }

    public void SetDescriptionGame(string value) {
        descriptionGame.text = value;
    }

    public void SetTitleSafeZone(string value) {
        titleSafeZone.text = value;
    }

    public void SetDescriptionSafeZone(string value) {
        descriptionSafeZone.text = value;
    }
    
}
