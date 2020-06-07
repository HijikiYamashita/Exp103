using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script2 : MonoBehaviour
{
    Vector3 vector = new Vector3(1, 2, 0);

    void Start()
    {
        vector *= 2.0f;
        Debug.Log(vector);
    }

    void Update()
    {

    }
}
