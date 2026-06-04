using UnityEngine;

public class Entry : MonoBehaviour {
    [SerializeField] private ControllerMain controllerMain;
    [SerializeField] private SettingGame settingGame;
    [SerializeField] private DataGame dataGame;
   
    private void Start() {
        Initialize();
    }

    private void Initialize() {
        controllerMain.Initialize(settingGame, dataGame);
    }

    private void OnDestroy() {
        controllerMain.Dispose();
        dataGame.ClearData();
    }
}




