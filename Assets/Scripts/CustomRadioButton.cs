using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CustomRadioButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private bool firstButton;
    [SerializeField] private Button button;
    [SerializeField] private Button[] otherButtons;

    public bool isSelected;

    void Start()
    {
        button.onClick.AddListener(OnButtonClicked);

        if (firstButton)
        {
            button.onClick.Invoke();
        }
    }

    private void OnButtonClicked()
    {
        if (isSelected == false) 
        {
            isSelected = true;
            button.GetComponent<Animator>().SetTrigger("Selected");
            foreach (var other in otherButtons)
            {
                other.GetComponent<Animator>().SetTrigger("Normal");
                other.GetComponent<CustomRadioButton>().isSelected = false;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isSelected == false)
        {
            button.GetComponent<Animator>().SetTrigger("Highlighted");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (isSelected == false)
        {
            button.GetComponent<Animator>().SetTrigger("Normal");
        }
    }
}
