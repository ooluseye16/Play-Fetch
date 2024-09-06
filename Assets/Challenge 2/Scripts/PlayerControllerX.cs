using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canSpawn = true;
    void Start()
    {
        //Repeatedly call allow spawn method at 1.5 seconds interval
        InvokeRepeating("AllowSpawn", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press and can spawn, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            //disable ability to spawn
            canSpawn = false;
        }
    }

    private void AllowSpawn()
    {
        //set canSpawn to true;
        canSpawn = true;
    }

}
