using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayer : MonoBehaviour {
    [SerializeField] private Button button;
    [SerializeField] private Text playerNumber;

    public Button Button => button;
    public void SetNumber(int number) {
        playerNumber.text = number.ToString();
    }
}
