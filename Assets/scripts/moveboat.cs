using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveboat : MonoBehaviour {

	public Rigidbody rb;
    public float sideForce ;
    public float forwardForce ;

	// Use this for initialization
	void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
	   float h = Input.GetAxis("Horizontal");
	   float v = Input.GetAxis("Vertical");


		// rb.AddTorque(0f, h *sideForce*Time.deltaTime, 0f);
		rb.AddForce(transform.forward*v*forwardForce*Time.deltaTime);
	   
	    // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }

    }
}