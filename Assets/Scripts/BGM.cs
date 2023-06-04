using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    static BGM AU; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        if (AU == null)
            AU = this;
        else if (AU != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}
