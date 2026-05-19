using UnityEngine;

public class Entry : MonoBehaviour {
    [SerializeField] private ControllerMain controllerMain;
   
    private void Start() {
        Initialize();
    }

    private void Initialize() {
        controllerMain.Initialize();
    }

    private void OnDestroy() {
        controllerMain.Dispose();
    }
}


