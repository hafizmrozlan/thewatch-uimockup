using UnityEngine;
using UnityEngine.UI;

public class ImageBlinker : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Vector2 alphaRange = new Vector2(0.1f, 1f);
    [SerializeField] private float blinkSpeed = 4f;

    void Update()
    {
        float alpha = Mathf.Sin(Time.time * blinkSpeed) * 0.5f + 0.5f;
        alpha = Mathf.Clamp(alpha, alphaRange.x, alphaRange.y);
        Color color = image.color;
        color.a = alpha;
        image.color = color;
    }
}
