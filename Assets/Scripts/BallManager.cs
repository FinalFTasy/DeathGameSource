using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (System.Math.Abs(rb.velocity.x) >= 0.001f || System.Math.Abs(rb.velocity.y) >= 0.001f)
        {
            rb.drag = (float) (System.Math.Sqrt(rb.drag + Time.deltaTime) / 1.2);
        }
        else
        {
            rb.drag = 0;
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish")
        {
            
        }
    }
}
