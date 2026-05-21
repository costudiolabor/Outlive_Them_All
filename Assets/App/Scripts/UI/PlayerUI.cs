using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {
    [SerializeField] private Text playerNumber;
    [SerializeField] private InputField playerName;

    private string playerNickname;  
    public string PlayerNickname => playerNickname;  
    public void Initialize(int number) {
        playerNumber.text = number.ToString();
        playerName.onValueChanged.AddListener(OnPlayerNameChanged);
    }

    private void OnPlayerNameChanged(string value) {
        playerNickname = value;
    }


    private void OnDestroy() {
        playerName.onValueChanged.RemoveAllListeners();
    }
    
    
}
