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
        if (context.started)
        {
            if (isonholdingscreen == true)
            {
                Destroy(UIScripterReference.uiElement);
                UIScripterReference.SpawnMainMenu();
                Debug.Log("started");
            }
        }


        
    }

    private void Update()
    {
        if(cc != null)
        {

        }
    }



}
