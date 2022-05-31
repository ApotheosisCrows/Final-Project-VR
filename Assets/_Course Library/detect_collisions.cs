using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_collisions : MonoBehaviour
{
    private Vector3 newSpawnLocation;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject mob1;
    //public GameObject mob2;
    //public GameObject mob3;

    Vector3[] spawnLocations = new Vector3[3];
    // Start is called before the first frame update
    void Start()
    {
        mob1 = this.gameObject;
        spawnLocations[0] = spawn1.transform.position;
        spawnLocations[1] = spawn2.transform.position;
        spawnLocations[2] = spawn3.transform.position;
        Debug.Log("Spawnloc0: " + spawnLocations[0]);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Projectile"))
        
           
        Destroy(other.gameObject);
        int picked = Random.Range(0, spawnLocations.Length);
        newSpawnLocation = spawnLocations[picked];
        Debug.Log("NewSpawnLocation: " + newSpawnLocation);
        Instantiate(mob1, newSpawnLocation, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
