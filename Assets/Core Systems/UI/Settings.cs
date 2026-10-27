using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] public UIScripter UIScripterReference;

    [SerializeField] private Dropdown qualityDropdown;


    public void SetQualityLevelDropdown(int index)
    {
        QualitySettings.SetQualityLevel(index, false);
    }

















    public void BackClicked()

    {
        Destroy(UIScripterReference.uiElement);
        UIScripterReference.SpawnMainMenu();
        Debug.Log("BackedOut of Settings");
    }
}
