using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public UIScripter manager;
    


    public void ClickSettings()
    {
        Destroy(manager.uiElement);
        manager.OpenSettings();
        Debug.Log("SettingsClicked");
    }
}
