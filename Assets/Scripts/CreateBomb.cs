using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBomb : MonoBehaviour
{
    public GameObject objToSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 offset = new Vector3(0, 0.5f, 0);
            GameObject clone = GameObject.Instantiate(objToSpawn, objToSpawn.transform.position + offset, Quaternion.identity);
            clone.transform.parent = transform;
            clone.AddComponent(System.Type.GetType("FallingBomb"));
        }
    }
}
