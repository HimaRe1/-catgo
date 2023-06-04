using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUIShow : MonoBehaviour
{
    
    public GameObject WhenChosen;
    public GameObject ClickShow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

           
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&&WhenChosen.activeSelf == true)
        {
            ClickShow.SetActive(true);
        }

    }
}
