using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MaskLight : MonoBehaviour
{
    // Start is called before the first frame update
    Light lt;
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Darken the light completely over a period of 2 seconds.
    void Update()
    {
        if(FirstPersonController.instance.Masked == false)
        {
            Color maskOff = new Color(255f, 255f, 255f, 180f);
            lt.color = (maskOff/400);
            RenderSettings.fogColor = maskOff/400;
        }else
        {
            Color maskOn = new Color(198f, 255f, 230f, 255f);
            lt.color = (maskOn/400);
            Color backCol = new Color(0f, 53f, 40f, 255f);
            RenderSettings.fogColor = backCol/300;
        }

    }
}
