using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuBtn : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn0);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn1);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn2);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn3);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn4);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn5);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn6);
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn7);
    }

    public void OnClickBtn0()
    {
        SceneManager.LoadScene("Level0livingroom");//要切换到的场景
    }
    public void OnClickBtn1()
    {
        SceneManager.LoadScene("Level1livingroom");//要切换到的场景
    }
    public void OnClickBtn2()
    {
        SceneManager.LoadScene("Level2livingroom");//要切换到的场景
    }
    public void OnClickBtn3()
    {
        SceneManager.LoadScene("Level3livingroom");//要切换到的场景
    }
    public void OnClickBtn4()
    {
        SceneManager.LoadScene("Level4livingroom");//要切换到的场景
    }
    public void OnClickBtn5()
    {
        SceneManager.LoadScene("Level5livingroom");//要切换到的场景
    }
    public void OnClickBtn6()
    {
        SceneManager.LoadScene("Level6livingroom");//要切换到的场景
    }
    public void OnClickBtn7()
    {
        SceneManager.LoadScene("Level7livingroom");//要切换到的场景
    }
    // Update is called once per frame
    void Update()
    {

    }
}
