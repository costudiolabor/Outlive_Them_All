using UnityEngine;

public class Entry : MonoBehaviour {
    [SerializeField] private ControllerMain controllerMain;
    [SerializeField] private SettingGame settingGame;
    [SerializeField] private DataGame dataGame;
    [SerializeField] private DataCharacter dataCharacter;
    
   
    private void Start() {
        Initialize();
    }

    private void Initialize() {
        controllerMain.Initialize(settingGame, dataGame, dataCharacter);
    }

    private void OnDestroy() {
        controllerMain.Dispose();
        dataGame.ClearData();
    }
}




