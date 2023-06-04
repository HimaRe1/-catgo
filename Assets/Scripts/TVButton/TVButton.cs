using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVButton : MonoBehaviour
{
    public GameObject Show1;
    public GameObject Show2;
    public GameObject Notshow1;
    public GameObject Notshow2;
    public GameObject Notshow3;
    public GameObject Notshow4;
    public GameObject Notshow5;
    public ClickControl Clickcontrol = new ClickControl();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Clickcontrol.dianji)
        {
            Show1.SetActive(true);
            Show2.SetActive(true);
            Notshow1.SetActive(false);
            Notshow2.SetActive(false);
            Notshow3.SetActive(false);
            Notshow4.SetActive(false);
            Notshow5.SetActive(false);
            Clickcontrol.dianji = !Clickcontrol.dianji;
        }
    }
}
