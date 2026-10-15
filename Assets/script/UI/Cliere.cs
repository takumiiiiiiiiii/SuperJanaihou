using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cliere : MonoBehaviour
{
    [SerializeField] private Image targetImage;

    private void Awake()
    {
        HideImage();
    }

    public void ShowImage()
    {
        Color c = targetImage.color;
        c.a = 1f;
        targetImage.color = c;
    }

    public void HideImage()
    {
        Color c = targetImage.color;
        c.a = 0f;
        targetImage.color = c;
    }



}
