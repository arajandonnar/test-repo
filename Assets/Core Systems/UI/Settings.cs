using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Dropdown qualityDropdown;


    public void SetQualityLevelDropdown(int index)
    {
        QualitySettings.SetQualityLevel(index, false);
    }
}
