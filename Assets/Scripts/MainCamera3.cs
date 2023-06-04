using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera3 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraMove();
    }
    public GameObject objectjudge1;
    public GameObject objectjudge2;
    public GameObject objectjudge3;
    public GameObject objectjudge4;
    public GameObject objectjudge5;
    public void CameraMove()
    {
        if (objectjudge1.activeSelf) ;
        else if (objectjudge2.activeSelf) ;
        else if(objectjudge3.activeSelf) ;
        else if (objectjudge4.activeSelf) ;
        else if (objectjudge5.activeSelf) ;

        else
        {
            if (Input.GetMouseButton(0))
            {
                this.gameObject.transform.Translate(Vector3.left * Input.GetAxis("Mouse X") * speed);
                if (this.gameObject.transform.position.x < -19)
                {
                    this.gameObject.transform.Translate(Vector3.right * Input.GetAxis("Mouse X") * speed);
                }
                else if (this.gameObject.transform.position.x > 19)
                {
                    this.gameObject.transform.Translate(Vector3.right * Input.GetAxis("Mouse X") * speed);
                }

            }
        }
    }
}
