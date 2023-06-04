using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControl : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public ClickControl Clickcontrol = new ClickControl();
    public ClickControl2 Clickcontrol2 = new ClickControl2();
    public ClickControl3 Clickcontrol3 = new ClickControl3();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Clickcontrol.dianji)
        {
            Canvas.SetActive(true);
            Clickcontrol.dianji = !Clickcontrol.dianji;
        }
        if (Clickcontrol2.dianji2)
        {
            Canvas2.SetActive(true);
            Clickcontrol2.dianji2 = !Clickcontrol2.dianji2;
        }
        if (Clickcontrol3.dianji3)
        {
            Canvas3.SetActive(true);
            Clickcontrol3.dianji3 = !Clickcontrol3.dianji3;
        }
    }
}