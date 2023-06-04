using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowShow : MonoBehaviour
{
    public GameObject WhenShow1;
    public GameObject WhenShow2;
    public GameObject WhenShow3;
    public GameObject ShowWhat1;
    public GameObject ShowWhat2;
    public GameObject ShowWhat3;
    public GameObject ShowWhat4;
    public GameObject ShowWhat5;
    // Start is called before the first frame update
    void Start()
    {

}

    // Update is called once per frame
    void Update()
    {
        if(WhenShow1.activeSelf==true&& WhenShow2.activeSelf == true && WhenShow3.activeSelf == true )
        {
            ShowWhat1.SetActive(true);
            ShowWhat2.SetActive(true);
            ShowWhat3.SetActive(true);
            ShowWhat4.SetActive(true);
            ShowWhat5.SetActive(true);

        }
    }
}
