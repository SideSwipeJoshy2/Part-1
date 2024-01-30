using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
    
{
    Rigidbody2D rigidbody; 

    public float fallForce = 1; //variable for the amount force the ball can fall with
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();   //references the rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddTorque(fallForce); //adds force to the ball 
    }
}
