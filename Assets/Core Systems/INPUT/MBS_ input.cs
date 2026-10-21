using UnityEngine;
using UnityEngine.InputSystem;

public class MBS_input : MonoBehaviour
{
    [SerializeField] UIScripter UIScripterReference;
   

    [SerializeField]
    private CharacterController cc;

    public bool isonholdingscreen;
    public void MouseInput(InputAction.CallbackContext context)
    {
        Debug.Log("LMBDETECTED");
        if (context.started)
        {
            Debug.Log("LeftMB");
            if (isonholdingscreen == true)
            {
                Destroy(UIScripterReference.uiElement);
                UIScripterReference.SpawnMainMenu();
                Debug.Log("started");
            }
        }


        
    }

    



}
