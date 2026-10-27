using UnityEngine;

public class MainMenu_Script : MonoBehaviour
{
    public UI_Scripter manager;

    public void PlayClicked()
    {
        manager.CallPlay();
    }

    public void SettingsClicked()
    {
        manager.CallSettings();
    }

    public void QuitClicked()
    {
        manager.CallLockin();
    }
}
