using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeBtn : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SceneManager.LoadScene("MainMenu");//要切换到的场景
        //FindObjectOfType<SceneFader>().FadeTo(sceneName);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
