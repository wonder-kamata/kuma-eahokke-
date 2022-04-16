using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollMove : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        rb.AddForce(13, 0, 0,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
