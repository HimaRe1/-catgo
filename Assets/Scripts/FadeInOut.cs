using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    private float fadeSpeed = 2.0f;
    private bool sceneStarting = true;
    private RawImage rawImage;

    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);

        rawImage = this.GetComponent<RawImage>();
    }

    void Update()
    {
        if (sceneStarting)
        {
            startScene();
        }
    }

    private void FadeToClear()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }


    private void startScene()
    {
        FadeToClear();

        if (rawImage.color.a <= 0.05f)
        {
            rawImage.color = Color.clear;
            rawImage.enabled = false;
            sceneStarting = false;
        }
    }

}