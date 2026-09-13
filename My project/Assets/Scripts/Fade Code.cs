using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeCode : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1f;

    public void FadeToBlack()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        Color color = fadeImage.color;

        float time = 0f;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;

            color.a = Mathf.Lerp(0f, 1f, time / fadeDuration);

            fadeImage.color = color;

            yield return null;
        }

        color.a = 1f;
        fadeImage.color = color;
    }
}
