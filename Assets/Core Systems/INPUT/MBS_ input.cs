using UnityEngine;
using UnityEngine.InputSystem;

public class MBS_input : MonoBehaviour
{



    [SerializeField]
    private CharacterController cc;

    private bool leftClick;
    public void MouseInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {

            //DestroyObject(GameObject.);
            Debug.Log("started");
        }


        
    }

    private void Update()
    {
        if(cc != null)
        {

        }
    }



}
