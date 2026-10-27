using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public UIScripter manager;
    

    public void ClickPlay()
    {
        Destroy(manager.uiElement);
        SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
        Debug.Log("iT Do Be Doin A Thing");
    }
    public void ClickSettings()
    {
        Destroy(manager.uiElement);
        manager.OpenSettings();
        Debug.Log("SettingsClicked");
    }

    public void QuitClicked()
    {
        Destroy(manager.uiElement);
        manager.OpenLockin();
        Debug.Log("Quit Clicked ?");
    }

}
