using UnityEngine;
using TMPro;
using UnityEditor;

public class UIScripter : MonoBehaviour
{
    [SerializeField]
    MBS_input inputReference;

    public GameObject HoldingScreen;
    public GameObject MainMenu;
    public GameObject ConfExit;
    public GameObject Settings;
    public Transform canvasTransform;

    [HideInInspector]
    public GameObject uiElement;

    void Start()
    {
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

    public void OpenSettings()
    {
        uiElement = Instantiate(Settings);
        uiElement.transform.SetParent(canvasTransform, false);
        Debug.Log("SettingSpawned");

        if (uiElement.TryGetComponent<Settings>(out Settings setting))
        {
            setting.UIScripterReference = this;
        }
    }

    public void OpenLockin()
    {
        uiElement = Instantiate(ConfExit);
        uiElement.transform.SetParent(canvasTransform, false);
        Debug.Log("You REALLY WANT TO LEAVE ?");

        if (uiElement.TryGetComponent<Lickin>(out Lickin LockIn))
        {
            LockIn.UIScripterReference = this;
        }

    }
}
 