using UnityEngine;
using UnityEngine.UI;

public class PanelLeft : View {
    [SerializeField] private Text nameGame;
    [SerializeField] private Text descriptionGame;
    [SerializeField] private Text titleSafeZone;
    [SerializeField] private Text descriptionSafeZone;

    public void Initialize(DataGame dataGame)
    {
        string value = dataGame.Scenario.title;
        SetNameGame(value);
        value = dataGame.Scenario.description;
        SetDescriptionGame(value);
        
        string nameLocation = dataGame.ScenarioLocation.location;
        int numberSeats = dataGame.GetNumberSeats();
        
        value = $"{nameLocation}\n\n"+
                $"Количество мест: {numberSeats}";
        SetDescriptionSafeZone(value);
    }
    
    
    public void SetNameGame(string value) {
        nameGame.text = value;
    }

    public void SetDescriptionGame(string value) {
        descriptionGame.text = value;
    }

    public void SetDescriptionSafeZone(string value) {
        descriptionSafeZone.text = value;
    }
    
}
