using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
        public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(FirstPersonController.instance.Masked == false)
        {
            Color backCol = new Color(0f, 0f, 0f, 0f);
            cam.backgroundColor = backCol/300;
        }else
        {
            Color backCol = new Color(0f, 53f, 40f, 255f);
            cam.backgroundColor = backCol/300;
        }
    }
}
