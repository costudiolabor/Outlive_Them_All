using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour {
    [SerializeField] private TMP_Text playerNumber;
    [SerializeField] private TMP_InputField playerName;

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
