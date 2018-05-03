using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstor : MonoBehaviour {
    public int healthPoints2;
    public int damage2;

    public GameObject denga;
    public GameObject[] loot;
    private GameObject go;
    public Vector3 monstorLocation;

	// Use this for initialization
	void Start ()
    {
        healthPoints2 = 50;
        damage2 = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (healthPoints2 == 0)
        {
            monstorLocation = gameObject.transform.position;
            Destroy(gameObject);
            //Instantiate(denga,
            //new Vector3(monstorLocation.x, monstorLocation.y, monstorLocation.z),
            // Quaternion.identity);

            go = Instantiate(loot[Random.Range(0, loot.Length)], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity) as GameObject;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "man")
        {
            Debug.Log(healthPoints2);
            healthPoints2 -= 25;
            Debug.Log(healthPoints2);
        }
    }
}
