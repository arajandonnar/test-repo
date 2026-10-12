using UnityEngine;
using TMPro;
using UnityEditor;

public class UIScripter : MonoBehaviour
{
    public GameObject HoldingScreen;
    public Transform canvasTransform;
    void Start()
    {
        GameObject uiElement = Instantiate(HoldingScreen);
        uiElement.transform.SetParent(canvasTransform, false);
        
    }
}
