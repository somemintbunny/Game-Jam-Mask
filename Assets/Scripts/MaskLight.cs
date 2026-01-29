using System.Collections;
using System.Collections.Generic;
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
            lt.color -= (Color.white / 2f) * Time.deltaTime;
        }

    }
}
