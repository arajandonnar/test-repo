using UnityEngine;
using UnityEngine.InputSystem;

public class MBS_input : MonoBehaviour
{



    [SerializeField]
    private CharacterController cc;

    private bool leftClick;
    public void MouseInput(InputAction.CallbackContext context)
    {
        Debug.Log("LMBDETECTED");
        if (context.started)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            Debug.Log("LeftMB");
            if (isonholdingscreen == true)
            {
                Destroy(UIScripterReference.uiElement);
                UIScripterReference.SpawnMainMenu();
                Debug.Log("started");
            }
=======

            //DestroyObject(GameObject.);
            Debug.Log("started");
>>>>>>> parent of 31104d4 (begun implementation of more core UI Systems)
=======

            //DestroyObject(GameObject.);
            Debug.Log("started");
>>>>>>> parent of 31104d4 (begun implementation of more core UI Systems)
        }


        
    }

    



}
