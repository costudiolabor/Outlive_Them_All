using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {
    [SerializeField] private Text playerNumber;
    [SerializeField] private InputField playerName;

    private int _number;  
    private string _playerNickname;  
    public int Number => _number;  
    public string PlayerNickname => _playerNickname;  
    
    public void Initialize(int number) {
        playerNumber.text = number.ToString();
        playerName.onValueChanged.AddListener(OnPlayerNameChanged);
    }

    private void OnPlayerNameChanged(string value) {
        _playerNickname = value;
    }


    private void OnDestroy() {
        playerName.onValueChanged.RemoveAllListeners();
    }
    
    
}
