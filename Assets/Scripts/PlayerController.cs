using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(x: -0.5f, y: 0, z: 0);
        }
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(x: 0, y: 0.5f, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(x: 0.5f, y: 0, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(x: 0, y: -0.5f, z: 0);
        }
    }
}