using UnityEngine;


[CreateAssetMenu(fileName = "SettingGame", menuName = "ScriptableObjects/SettingGame", order = 1)]
public class SettingGame : ScriptableObject {
    
    public int minTimer = 0;
    public int maxTimer = 1800;
    
}
