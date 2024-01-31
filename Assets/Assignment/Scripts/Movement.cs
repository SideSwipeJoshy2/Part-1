using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); 

    }

    // Update is called once per frame
    void Update()//moves the player horizontally and vertically and checks for both vertical/horizontal inputs
    {
        direction.x = Input.GetAxis("Horizontal"); 
        direction.y = Input.GetAxis("Vertical");

        transform.Translate(direction * speed * Time.deltaTime);

    }
    

    
}
