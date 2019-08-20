using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntity : MonoBehaviour
{
    [SerializeField]
    private GameObject Entity;
    [SerializeField]
    private float xSpawn;
    [SerializeField]
    private float ySpawn;
    private Vector2 position;

    void spawn()
    {
            position = new Vector2(xSpawn, ySpawn);
            Instantiate(Entity, position, transform.rotation);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            spawn();
    }
}
