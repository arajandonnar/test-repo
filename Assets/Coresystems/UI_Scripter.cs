using UnityEngine;

public class UI_Scripter : MonoBehaviour
{
    public Transform canvasTransform;
    public GameObject MainMenu;
    public GameObject Settings;


    private void Start()
    {
        GameObject uiElement = Instantiate(MainMenu);
        uiElement.transform.SetParent(canvasTransform, false);
    }

}
