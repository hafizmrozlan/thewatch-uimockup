using UnityEngine;

public class Indicator : MonoBehaviour
{
    [SerializeField] private RectTransform indicatorRectTransform;
    [SerializeField] private float speed = 10f;

    private Vector2 destination;
    [SerializeField] private Vector2 startingDestination;

    private void Start()
    {
        SetDestination(startingDestination);
    }

    private void Update()
    {
        if(Vector2.Distance(indicatorRectTransform.anchoredPosition, destination) > 0)
        {
            float step = (indicatorRectTransform.anchoredPosition - destination).magnitude * Time.deltaTime * speed;
            indicatorRectTransform.anchoredPosition = Vector2.MoveTowards(indicatorRectTransform.anchoredPosition, destination, step);
        }
    }

    public void SetDestination(Vector2 dest)
    {
        destination = dest;
    }
}
