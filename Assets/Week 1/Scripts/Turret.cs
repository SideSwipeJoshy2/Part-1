using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 30f;
        float direction = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, direction * Time.deltaTime * speed);

    }
}
