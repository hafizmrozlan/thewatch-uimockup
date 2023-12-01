using UnityEngine;

public class IndicatorTargetSetter : MonoBehaviour
{
    [SerializeField] private Indicator indicator;
    [SerializeField] private Vector2 currentPos;

    public void SetIndicatorDestination()
    {
        indicator.SetDestination(currentPos);
    }
}
