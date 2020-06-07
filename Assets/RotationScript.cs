using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    void Start()
    {
        this.transform.Rotate(Vector3.up * 30.0f, Space.World);
    }

    void Update()
    {
        
    }
}
