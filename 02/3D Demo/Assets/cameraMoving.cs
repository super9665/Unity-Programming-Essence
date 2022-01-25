using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoving : MonoBehaviour
{
    private Transform target;
    void Start()
    {
        target = FindObjectOfType<CubeScript>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + new Vector3(0f, 30f, 0f);
    }
}
