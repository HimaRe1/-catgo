using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControl2 : MonoBehaviour
{
    public GameObject Canvas;
    public ClickControl2 Clickcontrol = new ClickControl2();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Clickcontrol.dianji2)
        {
            Canvas.SetActive(true);
            Clickcontrol.dianji2 = !Clickcontrol.dianji2;
        }
    }
}