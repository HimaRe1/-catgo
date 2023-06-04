using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level0LivingroomMove : MonoBehaviour
{
    private Vector3 offset;
    public void OnpointDown()
    {//第一个函数，起这个名字，到时候好选择

        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //坐标转换一下，先取得Panel中心坐标和鼠标的差值
    }
    public void OnDrag()
    {//第二个函数


        transform.position = offset + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Drag就是拖动的意思，在拖动的时候，物体跟着鼠标
    }
    void Update()
    {

    }
}
