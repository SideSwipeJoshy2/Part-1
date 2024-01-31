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
        GameObject Ball = Instantiate(ballPrefab, spawn.position, spawn.rotation); //creates balls at the spawnpoint

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)) {
            Instantiate(ballPrefab, spawn.position,spawn.rotation); //if space is pressed it spawns balls at the spawnpoint
                                                                    }
    }
}
