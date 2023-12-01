using UnityEngine;
using UnityEngine.UI;

public class SelectOnStart : MonoBehaviour
{
    [SerializeField] private Selectable startingToggle;

    private void Start()
    {
        startingToggle.Select();
        //startingToggle.isOn = true;
    }
}
