using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {
    [SerializeField] private Text playerNumber;
    [SerializeField] private InputField playerName;

    private string _playerNickname;
    public int number;
    public string PlayerNickname
    {
        get => _playerNickname;
        set => _playerNickname = value;
    }

    public void Initialize(int number) {
        this.number = number;
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
