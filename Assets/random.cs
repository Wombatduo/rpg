using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random : MonoBehaviour {
    private float posX = 0f;
    private float posZ = 0f;
    private float posY = 0f;

    public GameObject enemy;
    private GameObject tempEnemy;
    public float SpawnTime = 0f;
    private float tempTime = 3f;

    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update ()
    {
        tempTime -= Time.deltaTime;
        if (tempTime <= 0f)
        {
            SpawnEnemy();
            tempTime = SpawnTime;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SpawnEnemy();
        }


    }
    void SpawnEnemy()
    // рандом
    {
        posX = Random.Range(-50, 50);
        posZ = Random.Range(-50, 50);

        tempEnemy = (GameObject)Instantiate(enemy, new Vector3(posX, 0, posZ), Quaternion.identity);
        Destroy(tempEnemy, 60);
    }
}
