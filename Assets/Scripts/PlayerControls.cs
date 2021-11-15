using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float MovementScale;
    public AudioHandler AudioHandler;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WalkSound());
    }

    // Update is called once per frame
    void Update () {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * MovementScale, ForceMode.Impulse);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.right * MovementScale, ForceMode.Impulse);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * MovementScale, ForceMode.Impulse);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.back * MovementScale, ForceMode.Impulse);
        }

        // if (rb.velocity.magnitude >= 0.3)
        // {
        //     AudioHandler.PlayOneShot("walk");
        // } else { AudioHandler.Stop("walk"); }
        
    }

    IEnumerator WalkSound()
    {
        while (true)
        {
            if (GetComponent<Rigidbody>().velocity.magnitude >= 0.3)
            {
                AudioHandler.Play("walk");
            }

            yield return new WaitForSeconds(0.4f);
        }
    }
}
