using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNotShow : MonoBehaviour
{
    public GameObject WhenShow1;
    public GameObject WhenShow2;
    public GameObject WhenShow3;
    public GameObject NotShowWhat1;
    public GameObject NotShowWhat2;
    public GameObject NotShowWhat3;
    public GameObject NotShowWhat4;
    public GameObject NotShowWhat5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WhenShow1.activeSelf == true && WhenShow2.activeSelf == true && WhenShow3.activeSelf == true)
        {
            NotShowWhat1.SetActive(false);
            NotShowWhat2.SetActive(false);
            NotShowWhat3.SetActive(false);
            NotShowWhat4.SetActive(false);
            NotShowWhat5.SetActive(false);

        }
    }
}
