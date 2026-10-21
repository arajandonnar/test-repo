using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public UIScripter manager;
    

    public void ClickPlay()
    {
        Destroy(manager.uiElement);
        manager.OpenGame();
    }
    public void ClickSettings()
    {
        Destroy(manager.uiElement);
        manager.OpenSettings();
        Debug.Log("SettingsClicked");
    }



}
