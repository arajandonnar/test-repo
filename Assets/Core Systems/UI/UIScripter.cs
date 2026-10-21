using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class UIScripter : MonoBehaviour
{
    public GameObject HoldingScreen;
    public Transform canvasTransform;
    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        Debug.Log("HoldingScreenSpwan");
        uiElement = Instantiate(HoldingScreen);
=======
        GameObject uiElement = Instantiate(HoldingScreen);
>>>>>>> parent of 31104d4 (begun implementation of more core UI Systems)
        uiElement.transform.SetParent(canvasTransform, false);
        
    }
<<<<<<< HEAD

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
=======
>>>>>>> parent of 31104d4 (begun implementation of more core UI Systems)
=======
        GameObject uiElement = Instantiate(HoldingScreen);
        uiElement.transform.SetParent(canvasTransform, false);
        
    }
>>>>>>> parent of 31104d4 (begun implementation of more core UI Systems)
}
