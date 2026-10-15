using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class UIImageColorWarp : MonoBehaviour
{
    [SerializeField] private Image targetImage;
    [SerializeField] private Color startColor = Color.white;
    [SerializeField] private Color endColor = Color.red;
    [SerializeField] private float duration = 1.5f;
    private Coroutine colorCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        targetImage.color = startColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeToEndColor()
    {
        StartColorChange(endColor);
    }
    public void ChangeToStartColor()
    {
        StartColorChange(startColor);
    }
    private void StartColorChange(Color targetColor)
    {
        if (colorCoroutine != null)
        {
            StopCoroutine(colorCoroutine);
        }
        colorCoroutine = StartCoroutine(ChangeColorCoroutine(targetColor));
    }

    private IEnumerator ChangeColorCoroutine(Color targetColor)
    {
        Color currentColor = targetImage.color;
        float time = 0f;
        while(time < duration)
        {
            time += Time.deltaTime;
            float t = Mathf.Clamp01(time / duration);
            targetImage.color = Color.Lerp(currentColor, targetColor,t);
            yield return null;
        }

        targetImage.color = targetColor;
        colorCoroutine = null;
    }
}
