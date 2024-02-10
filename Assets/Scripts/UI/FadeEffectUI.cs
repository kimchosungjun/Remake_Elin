using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffectUI : MonoBehaviour
{
    [SerializeField] private float fadeSpeed = 0.2f; 
    [SerializeField] private Image fadeImage;
    [SerializeField] private Color fadeColor;

    public void SetScreenAlpha(float _alpha)
    {
        fadeColor.a = _alpha;
        fadeImage.color = fadeColor;
    }

    public void ReferFadeImage()
    {
        if (fadeImage == null)
        {
            fadeImage = this.gameObject.GetComponent<Image>();
            fadeColor = fadeImage.color;
        }
    }

    public void FadeEffect(bool _isFadeIn)
    {
        ReferFadeImage();
        if (_isFadeIn)
            StartCoroutine("FadeIn");
        else
            StartCoroutine("FadeOut");
    }

    IEnumerator FadeIn() // ¹à¾ÆÁü
    {
        fadeColor.a = 1f;
        fadeImage.color = fadeColor;
        while (fadeColor.a > 0f)
        {
            fadeColor.a -= Time.deltaTime * fadeSpeed;
            fadeImage.color = fadeColor;
            yield return null;
        }
        yield break;
    }

    IEnumerator FadeOut() // ¾îµÎ¿öÁü
    {
        fadeColor.a = 0f;
        fadeImage.color = fadeColor;
        while (fadeColor.a < 1f)
        { 
            fadeColor.a += Time.deltaTime * fadeSpeed;
            fadeImage.color = fadeColor;
            yield return null;
        }
        yield break;
    }
}
