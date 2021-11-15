using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        Camera = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(Camera.transform.position);
        transform.eulerAngles = new Vector3(90, transform.eulerAngles.y, transform.eulerAngles.z);

    }
}