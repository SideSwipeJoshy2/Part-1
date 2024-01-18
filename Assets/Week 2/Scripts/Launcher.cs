using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Transform spawn;
    public GameObject missilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       GameObject missie =  Instantiate(missilePrefab, spawn.position, spawn.rotation);

    }
    // Update is called once per frame
    void Update()
    {
        //missile = GetComponent<Missile>();
        //transform.Translate(spawn.position);
    }
}
