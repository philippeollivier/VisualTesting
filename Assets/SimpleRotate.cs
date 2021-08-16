using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SimpleRotate : MonoBehaviour
{
    public float horzSpeed = 0f;

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, horzSpeed * Time.deltaTime);
    }
}
