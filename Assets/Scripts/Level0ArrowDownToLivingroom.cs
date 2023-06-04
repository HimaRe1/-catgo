using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level0ArrowDownToLivingroom : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClickBtn);

    }

    public void OnClickBtn()
    {
        SceneManager.LoadScene("Level0livingroom");//要切换到的场景
    }

    void Update()
    {

    }
}
