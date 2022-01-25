using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    private Rigidbody cubeRigidbody;
    float speed = 8f;
    float jumpCooltime;
    void Start()
    {
        cubeRigidbody = GetComponent<Rigidbody>();
        jumpCooltime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        jumpCooltime += Time.deltaTime;

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space) && jumpCooltime >= 0.5) {
            cubeRigidbody.AddForce(0f, 5000f, 0f);
            jumpCooltime = 0;
        }
        Vector3 direction = getNormalVector(xInput, 0, zInput) * speed;
        cubeRigidbody.velocity = direction;
    }

    Vector3 getNormalVector(float x, float y, float z) {
        Vector3 normalVector = new Vector3(x, y, z).normalized;
        return (normalVector);
    }
}
