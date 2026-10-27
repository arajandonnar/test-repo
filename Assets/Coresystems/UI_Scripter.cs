using UnityEngine;

public class UI_Scripter : MonoBehaviour
{
    public MainMenu_Script MainMenu_MBS;
    public Setting_script Setting_MBS;

    public Transform canvasTransform;
    public GameObject MainMenu_GO;
    public GameObject Settings;


    private void Start()
    {
        GameObject uiElement = Instantiate(MainMenu_GO);
        uiElement.transform.SetParent(canvasTransform, false);
        
    }
    //this is the 3 functions the buttons from the main menu script call
    public void CallPlay()
    {

    }
    public void CallSettings()
    {
        GameObject uiElement = Instantiate(Settings);
        uiElement.transform.SetParent(canvasTransform, false);
        
    }

    public void CallLockin()
    {

    }
}
