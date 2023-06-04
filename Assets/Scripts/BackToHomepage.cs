using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToHomepage : MonoBehaviour
{

    // Use this for initialization
    public Animator Anim;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
        Anim = GetComponent<Animator>();
    }

    public void OnClick()
    {
        SceneManager.LoadScene("HomePage");//要切换到的场景
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Anim.SetBool("Click", true);
        }
    }
}
