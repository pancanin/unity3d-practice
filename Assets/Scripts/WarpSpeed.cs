using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpSpeed : MonoBehaviour
{
    public GameObject moveable;
    public float warpSpeedMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // I wanted to change the 'speed' property of the plane but did not find an easy way how to do it.
            transform.Translate(Vector3.forward * warpSpeedMultiplier);
        }
    }
}
