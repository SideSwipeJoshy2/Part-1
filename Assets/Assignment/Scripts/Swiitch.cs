using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiitch : MonoBehaviour
{
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Door.activeInHierarchy == true)
        {
            Door.SetActive(false);
        }
        else
        {
            Door.SetActive(true);
        }
    }

   


    // Update is called once per frame
    void Update()
    {
        
    }
}
