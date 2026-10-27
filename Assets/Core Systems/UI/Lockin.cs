using Unity.VisualScripting;
using UnityEngine;

public class Lickin : MonoBehaviour
{
    [SerializeField]
    public UIScripter UIScripterReference;
    
    
    public void YesClicked()
    {
        Application.Quit();
        Debug.Log("BYE BYE");
    }

    public void NoClicked()
    {
        Destroy(UIScripterReference.uiElement);
        UIScripterReference.SpawnMainMenu();
        Debug.Log("No Quitty");
    }
}
