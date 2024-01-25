using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boost : MonoBehaviour
{
    
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
           rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (rigidbody.velocity.magnitude < 500)
        {

            rigidbody.AddTorque(100);
        }
    }
    // Update is called once per frame

    
    void Update()
    {
        
    }
}
