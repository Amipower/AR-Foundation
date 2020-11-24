using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;

[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    [Header("點擊後要生成的物件")]
    public GameObject obj;
    [Header("AR 管理器")]
    public ARRaycastManager arManager;
    public Vector2 pointMouse;
    public List<ARRaycastHit> hits;
    public void Tap() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            pointMouse = Input.mousePosition;
            print(pointMouse);
        }
    }
    public void Update()
    {
        Tap();
    }
}
