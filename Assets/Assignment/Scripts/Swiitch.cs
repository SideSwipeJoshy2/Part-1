using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiitch : MonoBehaviour
{
    public GameObject Hider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Hider.activeInHierarchy == true)//if colided with turns the visibility of the ball off, and vice verse
        {
            Hider.SetActive(false);

        }
        else
        {
            Hider.SetActive(true);
        }
    }

   


    // Update is called once per frame
    void Update()
    {
        
    }
}
