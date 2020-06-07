using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script1 : MonoBehaviour
{
    Vector3 vector = new Vector3(1.0f, 2.0f, 0);

    void Start()
    {
        vector += new Vector3(0, -2.0f, 2.0f);

        this.transform.position = vector;
    }

    void Update()
    {
        
    }
}
