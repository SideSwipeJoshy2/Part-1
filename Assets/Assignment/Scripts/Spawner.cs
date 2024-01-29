using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Transform spawn;
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject Ball = Instantiate(ballPrefab, spawn.position, spawn.rotation);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
