using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public float degreePerSecond;
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * degreePerSecond);
    }
}
