using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UIScripter : MonoBehaviour
{
    [SerializeField]
    MBS_input inputReference;

    public GameObject HoldingScreen;
    public GameObject MainMenu;
    public GameObject Settings;
    public Transform canvasTransform;

    [HideInInspector]
    public GameObject uiElement;

    void Start()
    {
        Debug.Log("HoldingScreenSpwan");
        uiElement = Instantiate(HoldingScreen);
        uiElement.transform.SetParent(canvasTransform, false);
        inputReference.isonholdingscreen = true;
        
    }

    public void SpawnMainMenu()
    {
        uiElement = Instantiate(MainMenu);
        uiElement.transform.SetParent(canvasTransform, false);
        inputReference.isonholdingscreen = false;
        Debug.Log("Mainmenu");
        //
        if (uiElement.TryGetComponent<MainMenu>(out MainMenu menu))
        {
            menu.manager = this;
        }
        
        
    }

    public void OpenGame()
    {
        
    }

    public void OpenSettings()
    {
        uiElement = Instantiate(Settings);
        uiElement.transform.SetParent(canvasTransform, false);
        Debug.Log("SettingSpawned");
    }
}
