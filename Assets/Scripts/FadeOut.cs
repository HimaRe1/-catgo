using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    private float fadeSpeed = 2.0f;
    private bool sceneEnding = false;
    private RawImage rawImage;
    public GameObject cat;
    void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);

        rawImage = this.GetComponent<RawImage>();
    }

    void Update()
    {
        if (cat.activeSelf)
        {
            sceneEnding = true;
        }
        if (sceneEnding)
        {
            EndScene();
        }

    }
    private void FadeToBlack()
    {
        rawImage.color = Color.Lerp(rawImage.color, Color.black, fadeSpeed * Time.deltaTime * 2);
    }

    public void EndScene()
    {

        rawImage.enabled = true;
        FadeToBlack();

    }
}