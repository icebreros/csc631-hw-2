using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createObject : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(-2, 40, -9);
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
