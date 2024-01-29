using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
    
{
    Rigidbody2D rigidbody;

    public float fallForce = 1;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 force = transform.position * fallForce * Time.deltaTime;
        rigidbody.AddForce(force);
    }
}
