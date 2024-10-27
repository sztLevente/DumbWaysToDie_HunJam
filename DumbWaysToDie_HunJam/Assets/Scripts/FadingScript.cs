using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class FadingScript : MonoBehaviour
{
    public SpriteRenderer yourSpriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yourSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        FadeIn();
    }
    private IEnumerator FadeIn()
    {
        float alphaVal = yourSpriteRenderer.color.a;
        Color tmp = yourSpriteRenderer.color;

        while (yourSpriteRenderer.color.a > 0)
        {
            alphaVal -= 0.01f;
            tmp.a = alphaVal;
            yourSpriteRenderer.color = tmp;

            yield return new WaitForSeconds(0.05f); // update interval
        }
    }

    private IEnumerator FadeOut()
    {
        float alphaVal = yourSpriteRenderer.color.a;
        Color tmp = yourSpriteRenderer.color;

        while (yourSpriteRenderer.color.a < 1)
        {
            alphaVal += 0.01f;
            tmp.a = alphaVal;
            yourSpriteRenderer.color = tmp;

            yield return new WaitForSeconds(0.05f); // update interval
        }
    }
}
