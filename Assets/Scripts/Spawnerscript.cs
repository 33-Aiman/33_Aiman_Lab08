using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    float PositionY;
    public GameObject[] SpawnerObjects;
    private int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        randomInt = Random.Range(0, SpawnerObjects.Length);
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        //Instantiate(SpawnObject, transform.position, transform.rotation);
        Instantiate(SpawnerObjects[randomInt], transform.position, transform.rotation);

    }
}
